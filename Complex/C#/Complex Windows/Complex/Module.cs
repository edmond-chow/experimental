/*
 *   Copyright 2022 Edmond Chow
 *   
 *   Licensed under the Apache License, Version 2.0 (the "License");
 *   you may not use this file except in compliance with the License.
 *   You may obtain a copy of the License at
 *   
 *       http://www.apache.org/licenses/LICENSE-2.0
 *   
 *   Unless required by applicable law or agreed to in writing, software
 *   distributed under the License is distributed on an "AS IS" BASIS,
 *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *   See the License for the specific language governing permissions and
 *   limitations under the License.
 */
using System;
using System.Text;
using System.Text.RegularExpressions;
internal static class Module
{
    internal interface INum
    {
        double this[int i] { get; set; }
    }
    private static readonly string Beg = @"(-|\+|^)";
    private static readonly string Sig = @"((\d+)(\.\d+|)([Ee](-|\+|)(\d+)|)|)";
    private static readonly string End = @"(?=(-|\+|$))";
    private const int BegI = 1;
    private const int SigI = 2;
    private const int TrmI = 8;
    private static string Group(this string[] Trm)
    {
        StringBuilder Rst = new StringBuilder("(");
        for (int i = 0; i < Trm.Length; ++i)
        {
            Rst.Append(i == 0 ? "" : "|").Append(Trm[i]);
        }
        Rst.Append(")");
        return Rst.ToString();
    }
    private static string Pat(params string[] Trm)
    {
        return Beg + Sig + Trm.Group() + End;
    }
    private static string Str(this double Num)
    {
        return Regex.Replace(Num.ToString("G17").ToLower(), "e-0(?=[1-9])", "e-");
    }
    internal static string ToString(this double[] Num, params string[] Trm)
    {
        if (Num.Length != Trm.Length) { throw new NotImplementedException("The branch should unreachable."); }
        StringBuilder Rst = new StringBuilder();
        bool Fst = true;
        for (int i = 0; i < Num.Length; ++i)
        {
            if (Num[i] == 0) { continue; }
            if (Num[i] > 0 && !Fst) { Rst.Append("+"); }
            else if (Num[i] == -1) { Rst.Append("-"); }
            if (Num[i] != 1 && Num[i] != -1) { Rst.Append(Num[i].Str()); }
            else if (Trm[i].Length == 0) { Rst.Append("1"); }
            Rst.Append(Trm[i]);
            Fst = false;
        }
        if (Fst) { Rst.Append("0"); }
        return Rst.ToString();
    }
    internal static string ToString<N>(ref N Rst, bool Vec, params string[] Trm) where N : INum
    {
        double[] Num = new double[Trm.Length];
        for (int i = 0, o = Vec ? 1 : 0; i < Num.Length; ++i) { Num[i] = Rst[i + o]; }
        return Num.ToString(Trm);
    }
    internal static double[] ToNumbers(this string Val, params string[] Trm)
    {
        double[] Num = new double[Trm.Length];
        Match Mat = Regex.Match(Val, Pat(Trm));
        int Cnt = 0;
        while (Mat.Success)
        {
            string BegV = Mat.Groups[BegI].Value;
            string SigV = Mat.Groups[SigI].Value;
            string TrmV = Mat.Groups[TrmI].Value;
            string Cap = BegV + SigV;
            int i = Array.IndexOf(Trm, TrmV);
            if (i == -1) { throw new NotImplementedException("The branch should unreachable."); }
            else if (SigV.Length == 0 && TrmV.Length == 0) { throw new ArgumentException("The string is invalid."); }
            else if (Cap.Length == 0 || Cap == "+") { ++Num[i]; }
            else if (Cap == "-") { --Num[i]; }
            else { Num[i] += double.Parse(Cap); }
            Cnt += Mat.Length;
            Mat = Mat.NextMatch();
        }
        if (Cnt != Val.Length) { throw new ArgumentException("The string is invalid."); }
        return Num;
    }
    internal static void ToNumbers<N>(this string Val, ref N Rst, bool Vec, params string[] Trm) where N : INum
    {
        double[] Num = Val.ToNumbers(Trm);
        for (int i = 0, o = Vec ? 1 : 0; i < Num.Length; ++i) { Rst[i + o] = Num[i]; }
    }
}
