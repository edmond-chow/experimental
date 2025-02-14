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
#pragma once
#include <cstddef>
#include <iomanip>
#include <string>
#include <regex>
#include <sstream>
#include <stdexcept>
inline constexpr const wchar_t* Ws = L" \t\n\v\f\r";
inline std::wstring Str(double Num)
{
	std::wstringstream Rst;
	Rst << std::defaultfloat << std::setprecision(17) << Num;
	return std::regex_replace(Rst.str(), std::wregex(L"e-0(?=[1-9])"), L"e-");
};
inline std::size_t stos_t(const std::wstring& Str)
{
	if (Str.find_first_not_of(Ws) > 0)
	{
		throw std::invalid_argument{ "The string cannot be converted as a size type." };
	}
	std::size_t Idx{ 0 };
	unsigned long long Rst{ std::stoull(Str, &Idx) };
	if (Idx < Str.size())
	{
		throw std::invalid_argument{ "The string cannot be converted as a size type." };
	}
	return static_cast<std::size_t>(Rst);
};
inline double stod_t(const std::wstring& Str)
{
	if (Str.find_first_not_of(Ws) > 0)
	{
		throw std::invalid_argument{ "The string cannot be converted as a double type." };
	}
	std::size_t Idx{ 0 };
	double Rst{ std::stod(Str, &Idx) };
	if (Idx < Str.size())
	{
		throw std::invalid_argument{ "The string cannot be converted as a double type." };
	}
	return Rst;
};
struct terms
{
private:
	const std::vector<std::wstring>* ptr;
	std::size_t siz;
public:
	terms(const std::vector<std::wstring>& ref)
		: ptr{ &ref }, siz{ 0 }
	{};
	terms(std::size_t siz)
		: ptr{ nullptr }, siz{ siz }
	{};
	bool empty() const
	{
		return ptr == nullptr;
	};
	std::size_t size() const
	{
		return ptr == nullptr ? siz : ptr->size();
	};
	std::wstring operator [](std::size_t i) const
	{
		return ptr == nullptr ? L"e" + std::to_wstring(i) : (*ptr)[i];
	};
};
inline constexpr const wchar_t Beg[] = LR"((-|\+|^))";
inline constexpr const wchar_t Sig[] = LR"(((\d+)(\.\d+|)([Ee](-|\+|)(\d+)|)|))";
inline constexpr const wchar_t End[] = LR"((?=(-|\+|$)))";
inline constexpr const std::size_t BegI = 1;
inline constexpr const std::size_t SigI = 2;
inline constexpr const std::size_t TrmI = 8;
inline std::wstring Group(const terms& Trm)
{
	if (Trm.empty())
	{
		return L"(e\\d+)";
	}
	std::wstringstream Rst;
	Rst << L"(";
	for (std::size_t i = 0; i < Trm.size(); ++i)
	{
		Rst << (i == 0 ? L"" : L"|") << Trm[i];
	}
	Rst << L")";
	return Rst.str();
};
inline std::wstring Pat(const terms& Trm)
{
	std::wstringstream Rst;
	Rst << Beg << Sig << Group(Trm) << End;
	return Rst.str();
};
inline std::wstring Replace(const std::wstring& Ipt, const std::wstring& Sch, const std::wstring& Rpt)
{
	std::wstring Rst = Ipt;
	std::size_t Pos = Rst.find(Sch);
	while (Pos != std::wstring::npos)
	{
		Rst = Rst.replace(Pos, Sch.size(), Rpt);
		Pos = Rst.find(Sch, Pos + Rpt.size());
	}
	return Rst;
};
inline std::wstring ToString(const std::vector<double>& Num, const terms& Trm)
{
	if (Num.size() != Trm.size()) { throw std::runtime_error{ "The branch should unreachable." }; }
	std::wstringstream Rst;
	bool Fst = true;
	for (std::size_t i = 0; i < Num.size(); ++i)
	{
		if (Num[i] == 0) { continue; }
		if (Num[i] > 0 && !Fst) { Rst << L"+"; }
		else if (Num[i] == -1) { Rst << L"-"; }
		if (Num[i] != 1 && Num[i] != -1) { Rst << Str(Num[i]); }
		else if (Trm[i].empty()) { Rst << L"1"; }
		if (!Trm[i].empty()) { Rst << Trm[i]; }
		Fst = false;
	}
	if (Fst) { Rst << L"0"; }
	return Rst.str();
};
template <typename N, typename... Ts>
std::wstring ToString(N& Rst, bool Vec, Ts... As)
{
	std::vector<std::wstring> Trm{ As... };
	std::vector<double> Num(Trm.size());
	for (std::size_t i = 0, o = Vec ? 1 : 0; i < Trm.size(); ++i) { Num[i] = Rst[i + o]; }
	return ToString(Num, Trm);
};
inline std::vector<double> ToNumbers(const std::wstring& Val, const terms& Trm)
{
	std::size_t Siz = Trm.size();

	std::vector<double> Num(Siz);
	std::wsmatch Mat;
	std::wstring Suf{ Val };
	std::regex_constants::match_flag_type Flg{ std::regex_constants::match_default };
	while (std::regex_search(Suf, Mat, std::wregex{ Pat(Trm) }, Flg))
	{
		std::wstring BegV = Mat.str(BegI);
		std::wstring SigV = Mat.str(SigI);
		std::wstring TrmV = Mat.str(TrmI);
		std::wstring Cap = BegV + SigV;
		std::size_t i{ 0 };
		if (Trm.empty()) { i = stos_t(Trm[i]); }
		else
		{
			while (Trm[i] != TrmV && i < Siz) { ++i; }
			if (i == Siz) { throw std::runtime_error{ "The branch should unreachable." }; }
		}
		if (SigV.empty() && TrmV.empty()) { throw std::invalid_argument{ "The string is invalid." }; }
		else if (Cap.empty() || Cap == L"+") { ++Num[i]; }
		else if (Cap == L"-") { --Num[i]; }
		else { Num[i] += stod_t(Cap); }
		Suf = Mat.suffix().str();
		Flg |= std::regex_constants::match_not_bol;
	}
	if (Suf.size() != 0) { throw std::invalid_argument{ "The string is invalid." }; }
	return Num;
};
template <typename N, typename... Ts>
void ToNumbers(const std::wstring& Val, N& Rst, bool Vec, Ts... As)
{
	std::vector<std::wstring> Trm{ As... };
	std::vector<double> Num = ToNumbers(Val, Trm);
	for (std::size_t i = 0, o = Vec ? 1 : 0; i < Trm.size(); ++i) { Rst[i + o] = Num[i]; }
};
#pragma pack(push)
#pragma push_macro("Ths")
#if defined(X86) || defined(ARM)
#pragma pack(4)
#elif defined(X64) || defined(ARM64)
#pragma pack(8)
#endif
#if defined(_MSVC_LANG)
#define Ths __thiscall
#else
#define Ths
#endif
namespace Num
{
	class String
	{
	private:
		wchar_t* Pointer;
	public:
		Ths String();
		Ths String(const wchar_t* Pt);
		String(const String& Self) = delete;
		Ths String(String&& Self) noexcept;
		String& operator =(const String& O) & = delete;
		String& Ths operator =(String&& O) & noexcept;
		Ths ~String() noexcept;
		const wchar_t* Ths Ptr() const&;
	};
}
#pragma pop_macro("Ths")
#pragma pack(pop)
