Public Class NumberSystemsConversionCalculator
    Public Structure Number
        ReadOnly Value As String
        ReadOnly Base As Integer
        Sub New(Value As String, Base As Integer)
            Me.Value = Value
            Me.Base = Base
            If Base > 36 Or Base < 2 Then
                Throw New Exception
            End If
            Dim x() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
            Dim s = Me.Value
            For t As Integer = 0 To Base - 1
                s = s.Replace(x(t), "")
            Next
            If s = "" Or s = "." Then
            Else
                Throw New Exception
            End If
        End Sub
        Public Overloads Function ToString() As String
            Return Me.Value + Me.Base.ToString.Replace("0", "₀").Replace("1", "₁").Replace("2", "₂").Replace("3", "₃").Replace("4", "₄").Replace("5", "₅").Replace("6", "₆").Replace("7", "₇").Replace("8", "₈").Replace("9", "₉")
        End Function
        Public Shared Widening Operator CType(num As Number) As String
            Return _ToString_(num)
        End Operator
        Public Shared Widening Operator CType(str As String) As Number
            Return _ToNumber_(str)
        End Operator
        Public Shared Operator +(v1 As Number, v2 As Number) As Number
            Return New Number((CDbl(Convert(v1, 10).Value) + CDbl(Convert(v2, 10).Value)).ToString, 10)
        End Operator
        Public Shared Operator -(v1 As Number, v2 As Number) As Number
            Return New Number((CDbl(Convert(v1, 10).Value) - CDbl(Convert(v2, 10).Value)).ToString, 10)
        End Operator
        Public Shared Operator *(v1 As Number, v2 As Number) As Number
            Return New Number((CDbl(Convert(v1, 10).Value) * CDbl(Convert(v2, 10).Value)).ToString, 10)
        End Operator
        Public Shared Operator /(v1 As Number, v2 As Number) As Number
            Return New Number((CDbl(Convert(v1, 10).Value) / CDbl(Convert(v2, 10).Value)).ToString, 10)
        End Operator
        Public Shared Operator ^(v1 As Number, v2 As Number) As Number
            Return New Number((CDbl(Convert(v1, 10).Value) ^ CDbl(Convert(v2, 10).Value)).ToString, 10)
        End Operator
        Public Shared Operator \(v1 As Number, v2 As Number) As Number
            Return New Number((CDbl(Convert(v1, 10).Value) \ CDbl(Convert(v2, 10).Value)).ToString, 10)
        End Operator
    End Structure
    Public Shared Function _ToString_(Number As Number) As String
        Return Number.ToString
    End Function
    Public Shared Function _ToNumber_(Number As String) As Number
        Dim s = Number.Replace("₀", "").Replace("₁", "").Replace("₂", "").Replace("₃", "").Replace("₄", "").Replace("₅", "").Replace("₆", "").Replace("₇", "").Replace("₈", "").Replace("₉", "")
        Dim f = Number.Replace(s, "")
        If f = "" Then
            f = "10"
        End If
        Dim x = f.Replace("₀", "0").Replace("₁", "1").Replace("₂", "2").Replace("₃", "3").Replace("₄", "4").Replace("₅", "5").Replace("₆", "6").Replace("₇", "7").Replace("₈", "8").Replace("₉", "9")
        Return New Number(s, x)
    End Function
    Public Shared Function Convert(Number As Number, NewBase As Integer) As Number
        Dim x As Int64
        If Number.Base > 36 Or NewBase > 36 Or Number.Base < 2 Or NewBase < 2 Then
            Throw New Exception
        End If
        Dim Value() As Char = Number.Value.Split(".")(0).ToCharArray
        Dim Value_d() As Char = (Number.Value + ".").Split(".")(1).ToCharArray
        Dim Value_Num() As String = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
        Dim Value_Num_d() As String = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
        Dim L As Int64 = Number.Value.Split(".")(0).Length
        Dim L_d As Int64 = (Number.Value + ".").Split(".")(1).Length
        For x = 0 To L - 1
            If Value(x) = "0" Then
                Value_Num(x) = 0
            ElseIf Value(x) = "1" Then
                Value_Num(x) = 1
            ElseIf Value(x) = "2" Then
                Value_Num(x) = 2
            ElseIf Value(x) = "3" Then
                Value_Num(x) = 3
            ElseIf Value(x) = "4" Then
                Value_Num(x) = 4
            ElseIf Value(x) = "5" Then
                Value_Num(x) = 5
            ElseIf Value(x) = "6" Then
                Value_Num(x) = 6
            ElseIf Value(x) = "7" Then
                Value_Num(x) = 7
            ElseIf Value(x) = "8" Then
                Value_Num(x) = 8
            ElseIf Value(x) = "9" Then
                Value_Num(x) = 9
            ElseIf Value(x) = "A" Then
                Value_Num(x) = 10
            ElseIf Value(x) = "B" Then
                Value_Num(x) = 11
            ElseIf Value(x) = "C" Then
                Value_Num(x) = 12
            ElseIf Value(x) = "D" Then
                Value_Num(x) = 13
            ElseIf Value(x) = "E" Then
                Value_Num(x) = 14
            ElseIf Value(x) = "F" Then
                Value_Num(x) = 15
            ElseIf Value(x) = "G" Then
                Value_Num(x) = 16
            ElseIf Value(x) = "H" Then
                Value_Num(x) = 17
            ElseIf Value(x) = "I" Then
                Value_Num(x) = 18
            ElseIf Value(x) = "J" Then
                Value_Num(x) = 19
            ElseIf Value(x) = "K" Then
                Value_Num(x) = 20
            ElseIf Value(x) = "L" Then
                Value_Num(x) = 21
            ElseIf Value(x) = "M" Then
                Value_Num(x) = 22
            ElseIf Value(x) = "N" Then
                Value_Num(x) = 23
            ElseIf Value(x) = "O" Then
                Value_Num(x) = 24
            ElseIf Value(x) = "P" Then
                Value_Num(x) = 25
            ElseIf Value(x) = "Q" Then
                Value_Num(x) = 26
            ElseIf Value(x) = "R" Then
                Value_Num(x) = 27
            ElseIf Value(x) = "S" Then
                Value_Num(x) = 28
            ElseIf Value(x) = "T" Then
                Value_Num(x) = 29
            ElseIf Value(x) = "U" Then
                Value_Num(x) = 30
            ElseIf Value(x) = "V" Then
                Value_Num(x) = 31
            ElseIf Value(x) = "W" Then
                Value_Num(x) = 32
            ElseIf Value(x) = "X" Then
                Value_Num(x) = 33
            ElseIf Value(x) = "Y" Then
                Value_Num(x) = 34
            ElseIf Value(x) = "Z" Then
                Value_Num(x) = 35
            End If
        Next
        For x = 0 To L_d - 1
            If Value_d(x) = "0" Then
                Value_Num_d(x) = 0
            ElseIf Value_d(x) = "1" Then
                Value_Num_d(x) = 1
            ElseIf Value_d(x) = "2" Then
                Value_Num_d(x) = 2
            ElseIf Value_d(x) = "3" Then
                Value_Num_d(x) = 3
            ElseIf Value_d(x) = "4" Then
                Value_Num_d(x) = 4
            ElseIf Value_d(x) = "5" Then
                Value_Num_d(x) = 5
            ElseIf Value_d(x) = "6" Then
                Value_Num_d(x) = 6
            ElseIf Value_d(x) = "7" Then
                Value_Num_d(x) = 7
            ElseIf Value_d(x) = "8" Then
                Value_Num_d(x) = 8
            ElseIf Value_d(x) = "9" Then
                Value_Num_d(x) = 9
            ElseIf Value_d(x) = "A" Then
                Value_Num_d(x) = 10
            ElseIf Value_d(x) = "B" Then
                Value_Num_d(x) = 11
            ElseIf Value_d(x) = "C" Then
                Value_Num_d(x) = 12
            ElseIf Value_d(x) = "D" Then
                Value_Num_d(x) = 13
            ElseIf Value_d(x) = "E" Then
                Value_Num_d(x) = 14
            ElseIf Value_d(x) = "F" Then
                Value_Num_d(x) = 15
            ElseIf Value_d(x) = "G" Then
                Value_Num_d(x) = 16
            ElseIf Value_d(x) = "H" Then
                Value_Num_d(x) = 17
            ElseIf Value_d(x) = "I" Then
                Value_Num_d(x) = 18
            ElseIf Value_d(x) = "J" Then
                Value_Num_d(x) = 19
            ElseIf Value_d(x) = "K" Then
                Value_Num_d(x) = 20
            ElseIf Value_d(x) = "L" Then
                Value_Num_d(x) = 21
            ElseIf Value_d(x) = "M" Then
                Value_Num_d(x) = 22
            ElseIf Value_d(x) = "N" Then
                Value_Num_d(x) = 23
            ElseIf Value_d(x) = "O" Then
                Value_Num_d(x) = 24
            ElseIf Value_d(x) = "P" Then
                Value_Num_d(x) = 25
            ElseIf Value_d(x) = "Q" Then
                Value_Num_d(x) = 26
            ElseIf Value_d(x) = "R" Then
                Value_Num_d(x) = 27
            ElseIf Value_d(x) = "S" Then
                Value_Num_d(x) = 28
            ElseIf Value_d(x) = "T" Then
                Value_Num_d(x) = 29
            ElseIf Value_d(x) = "U" Then
                Value_Num_d(x) = 30
            ElseIf Value_d(x) = "V" Then
                Value_Num_d(x) = 31
            ElseIf Value_d(x) = "W" Then
                Value_Num_d(x) = 32
            ElseIf Value_d(x) = "X" Then
                Value_Num_d(x) = 33
            ElseIf Value_d(x) = "Y" Then
                Value_Num_d(x) = 34
            ElseIf Value_d(x) = "Z" Then
                Value_Num_d(x) = 35
            End If
        Next
        Dim Dec As Int64 = 0
        Dim Dec_d As Double = 0
        For x = 1 To L
            Dec += Value_Num(x - 1) * Number.Base ^ (L - x)
        Next
        For x = 1 To L_d
            Dec_d += Value_Num_d(x - 1) * Number.Base ^ (-x)
        Next
        If Dec = 0 Then
            Return New Number(Dec, NewBase)
        Else
            Dim Power As Int64 = Math.Floor(Math.Log(Dec, NewBase))
            Dim Ans() As String = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
            Dim Ans_d() As String = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
            Dim Remainder As Int64 = Dec
            Dim Remainder_d As Double = Dec_d
            For x = 0 To Power
                Ans(x) = Math.Floor(Remainder / NewBase ^ (Power - x))
                Remainder = Remainder - Ans(x) * NewBase ^ (Power - x)
            Next
            For x = 0 To 32
                Ans_d(x) = Math.Floor(Remainder_d / NewBase ^ (-x - 1))
                Remainder_d = Remainder_d - Ans_d(x) * NewBase ^ (-x - 1)
            Next
            If Ans_d(32) >= NewBase Then
                Ans_d(31) = Ans_d(31) + 1
                For x = 31 To 0 Step -1
                    If Ans_d(x) = 10 Then
                        Ans_d(x) = 0
                        Ans_d(x - 1) = Ans_d(x - 1) + 1
                    End If
                Next
            End If
            Ans_d(32) = ""
            For x = 0 To 63
                If Ans(x) = "0" Then
                    Ans(x) = "0"
                ElseIf Ans(x) = "1" Then
                    Ans(x) = "1"
                ElseIf Ans(x) = "2" Then
                    Ans(x) = "2"
                ElseIf Ans(x) = "3" Then
                    Ans(x) = "3"
                ElseIf Ans(x) = "4" Then
                    Ans(x) = "4"
                ElseIf Ans(x) = "5" Then
                    Ans(x) = "5"
                ElseIf Ans(x) = "6" Then
                    Ans(x) = "6"
                ElseIf Ans(x) = "7" Then
                    Ans(x) = "7"
                ElseIf Ans(x) = "8" Then
                    Ans(x) = "8"
                ElseIf Ans(x) = "9" Then
                    Ans(x) = "9"
                ElseIf Ans(x) = "10" Then
                    Ans(x) = "A"
                ElseIf Ans(x) = "11" Then
                    Ans(x) = "B"
                ElseIf Ans(x) = "12" Then
                    Ans(x) = "C"
                ElseIf Ans(x) = "13" Then
                    Ans(x) = "D"
                ElseIf Ans(x) = "14" Then
                    Ans(x) = "E"
                ElseIf Ans(x) = "15" Then
                    Ans(x) = "F"
                ElseIf Ans(x) = "16" Then
                    Ans(x) = "G"
                ElseIf Ans(x) = "17" Then
                    Ans(x) = "H"
                ElseIf Ans(x) = "18" Then
                    Ans(x) = "I"
                ElseIf Ans(x) = "19" Then
                    Ans(x) = "J"
                ElseIf Ans(x) = "20" Then
                    Ans(x) = "K"
                ElseIf Ans(x) = "21" Then
                    Ans(x) = "L"
                ElseIf Ans(x) = "22" Then
                    Ans(x) = "M"
                ElseIf Ans(x) = "23" Then
                    Ans(x) = "N"
                ElseIf Ans(x) = "24" Then
                    Ans(x) = "O"
                ElseIf Ans(x) = "25" Then
                    Ans(x) = "P"
                ElseIf Ans(x) = "26" Then
                    Ans(x) = "Q"
                ElseIf Ans(x) = "27" Then
                    Ans(x) = "R"
                ElseIf Ans(x) = "28" Then
                    Ans(x) = "S"
                ElseIf Ans(x) = "29" Then
                    Ans(x) = "T"
                ElseIf Ans(x) = "30" Then
                    Ans(x) = "U"
                ElseIf Ans(x) = "31" Then
                    Ans(x) = "V"
                ElseIf Ans(x) = "32" Then
                    Ans(x) = "W"
                ElseIf Ans(x) = "33" Then
                    Ans(x) = "X"
                ElseIf Ans(x) = "34" Then
                    Ans(x) = "Y"
                ElseIf Ans(x) = "35" Then
                    Ans(x) = "Z"
                End If
            Next
            For x = 0 To 63
                If Ans_d(x) = "0" Then
                    Ans_d(x) = "0"
                ElseIf Ans_d(x) = "1" Then
                    Ans_d(x) = "1"
                ElseIf Ans_d(x) = "2" Then
                    Ans_d(x) = "2"
                ElseIf Ans_d(x) = "3" Then
                    Ans_d(x) = "3"
                ElseIf Ans_d(x) = "4" Then
                    Ans_d(x) = "4"
                ElseIf Ans_d(x) = "5" Then
                    Ans_d(x) = "5"
                ElseIf Ans_d(x) = "6" Then
                    Ans_d(x) = "6"
                ElseIf Ans_d(x) = "7" Then
                    Ans_d(x) = "7"
                ElseIf Ans_d(x) = "8" Then
                    Ans_d(x) = "8"
                ElseIf Ans_d(x) = "9" Then
                    Ans_d(x) = "9"
                ElseIf Ans_d(x) = "10" Then
                    Ans_d(x) = "A"
                ElseIf Ans_d(x) = "11" Then
                    Ans_d(x) = "B"
                ElseIf Ans_d(x) = "12" Then
                    Ans_d(x) = "C"
                ElseIf Ans_d(x) = "13" Then
                    Ans_d(x) = "D"
                ElseIf Ans_d(x) = "14" Then
                    Ans_d(x) = "E"
                ElseIf Ans_d(x) = "15" Then
                    Ans_d(x) = "F"
                ElseIf Ans_d(x) = "16" Then
                    Ans_d(x) = "G"
                ElseIf Ans_d(x) = "17" Then
                    Ans_d(x) = "H"
                ElseIf Ans_d(x) = "18" Then
                    Ans_d(x) = "I"
                ElseIf Ans_d(x) = "19" Then
                    Ans_d(x) = "J"
                ElseIf Ans_d(x) = "20" Then
                    Ans_d(x) = "K"
                ElseIf Ans_d(x) = "21" Then
                    Ans_d(x) = "L"
                ElseIf Ans_d(x) = "22" Then
                    Ans_d(x) = "M"
                ElseIf Ans_d(x) = "23" Then
                    Ans_d(x) = "N"
                ElseIf Ans_d(x) = "24" Then
                    Ans_d(x) = "O"
                ElseIf Ans_d(x) = "25" Then
                    Ans_d(x) = "P"
                ElseIf Ans_d(x) = "26" Then
                    Ans_d(x) = "Q"
                ElseIf Ans_d(x) = "27" Then
                    Ans_d(x) = "R"
                ElseIf Ans_d(x) = "28" Then
                    Ans_d(x) = "S"
                ElseIf Ans_d(x) = "29" Then
                    Ans_d(x) = "T"
                ElseIf Ans_d(x) = "30" Then
                    Ans_d(x) = "U"
                ElseIf Ans_d(x) = "31" Then
                    Ans_d(x) = "V"
                ElseIf Ans_d(x) = "32" Then
                    Ans_d(x) = "W"
                ElseIf Ans_d(x) = "33" Then
                    Ans_d(x) = "X"
                ElseIf Ans_d(x) = "34" Then
                    Ans_d(x) = "Y"
                ElseIf Ans_d(x) = "35" Then
                    Ans_d(x) = "Z"
                End If
            Next
            Dim OutPut As String = ""
            Dim OutPut_d As String = ""
            For x = 1 To 64
                OutPut += Ans(x - 1)
            Next
            Dim y As Boolean = False
            For x = 32 To 1 Step -1
                If Ans_d(x - 1) = "0" And y = False Then
                Else
                    OutPut_d = Ans_d(x - 1) + OutPut_d
                    y = True
                End If
            Next
            If OutPut_d = "" Then
            Else
                OutPut_d = "." + OutPut_d
            End If
            Return New Number(OutPut + OutPut_d, NewBase)
        End If
    End Function
    Public Shared Function Convert(Number As String, NewBase As Integer) As Number
        Return Convert(_ToNumber_(Number), NewBase)
    End Function
End Class
