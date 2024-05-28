﻿#include "Base.h"
#include "Sedenion.h"
using namespace ComplexTestingConsole;
using namespace Seden;
namespace SedenBasis
{
	template <typename F = Sedenion(SEDEN_FUNC_CALL*)(const Sedenion&, const Sedenion&)>
	void multiple(const std::wstring& LeftValue, const wchar_t* RightValue, F Subroutine)
	{
		if (LeftValue == RightValue)
		{
			Sedenion Union = Sedenion::GetInstance(Base::Input(L"Union = "));
			Sedenion Value = Sedenion::GetInstance(Base::Input(L"Value = "));
			Base::Output(to_wstring(std::invoke(Subroutine, Union, Value)));
		}
	};
	template <typename F = Sedenion(SEDEN_FUNC_CALL*)(const Sedenion&, const Sedenion&)>
	void op(const std::wstring& LeftValue, const wchar_t* RightValue, F Subroutine)
	{
		if (LeftValue == RightValue)
		{
			Sedenion Union = Sedenion::GetInstance(Base::Input(L"Union = "));
			Sedenion Value = Sedenion::GetInstance(Base::Input(L"Value = "));
			Base::Output(to_wstring(std::invoke(Subroutine, Union, Value)));
		}
	};
	inline void op(const std::wstring& LeftValue, const wchar_t* RightValue, Sedenion(SEDEN_FUNC_CALL* Subroutine)(const Sedenion&, double))
	{
		if (LeftValue == RightValue)
		{
			Sedenion Union = Sedenion::GetInstance(Base::Input(L"Union = "));
			double Value = ParseAsReal(Base::Input(L"Value = "));
			Base::Output(to_wstring(std::invoke(Subroutine, Union, Value)));
		}
	};
	template <typename F>
	void power(const std::wstring& LeftValue, const wchar_t* RightValue, F Subroutine)
	{
		if (LeftValue == RightValue)
		{
			Sedenion Base = Sedenion::GetInstance(Base::Input(L"Base = "));
			std::int64_t Exponent = ParseAsInteger(Base::Input(L"Exponent = "));
			Base::Output(to_wstring(std::invoke(Subroutine, Base, Exponent)));
		}
	};
	template <typename... args>
	void power(const std::wstring& LeftValue, std::wstring&& RightValue, Sedenion(SEDEN_FUNC_CALL* Subroutine)(const Sedenion&, const Sedenion&, std::int64_t, args...))
	{
		if (LeftValue == RightValue)
		{
			Sedenion Union = Sedenion::GetInstance(Base::Input(L"Union = "));
			Sedenion Value = Sedenion::GetInstance(Base::Input(L"Value = "));
			std::array<std::int64_t, 1 + sizeof...(args)> Data{};
			power_get(Data);
			power_result(Subroutine, RightValue, Union, Value, Data);
		}
		else if (LeftValue == RightValue + L"()")
		{
			Sedenion Union = Sedenion::GetInstance(Base::Input(L"Union = "));
			Sedenion Value = Sedenion::GetInstance(Base::Input(L"Value = "));
			std::array<std::pair<std::int64_t, std::int64_t>, 1 + sizeof...(args)> Data{};
			power_get(Data);
			power_result(Subroutine, RightValue, Union, Value, Data);
		}
	};
	template <typename F>
	void basic(const std::wstring& LeftValue, const wchar_t* RightValue, F Subroutine)
	{
		if (LeftValue == RightValue)
		{
			Sedenion Value = Sedenion::GetInstance(Base::Input(L"Value = "));
			Base::Output(to_wstring(std::invoke(Subroutine, Value)));
		}
	};
	template <typename R>
	void basic(const std::wstring& LeftValue, std::wstring&& RightValue, R(SEDEN_FUNC_CALL* Subroutine)(const Sedenion&, std::int64_t))
	{
		if (LeftValue == RightValue)
		{
			Sedenion Value = Sedenion::GetInstance(Base::Input(L"Value = "));
			std::int64_t Theta = ParseAsInteger(Base::Input(L"Theta = "));
			Base::Output(to_wstring(std::invoke(Subroutine, Value, Theta)));
		}
		else if (LeftValue == RightValue + L"()")
		{
			Sedenion Value = Sedenion::GetInstance(Base::Input(L"Value = "));
			std::int64_t ThetaMin = ParseAsInteger(Base::Input(L"ThetaMin = "));
			std::int64_t ThetaMax = ParseAsInteger(Base::Input(L"ThetaMax = "));
			for (std::int64_t Theta = ThetaMin; Theta <= ThetaMax; ++Theta)
			{
				Base::Output(RightValue + L"(" + to_wstring(Theta) + L") = ", to_wstring(std::invoke(Subroutine, Value, Theta)));
			}
		}
	};
	template <typename F = Sedenion(SEDEN_FUNC_CALL*)(const Sedenion&)>
	inline void tri(const std::wstring& LeftValue, const wchar_t* RightValue, F Subroutine)
	{
		if (LeftValue == RightValue)
		{
			Sedenion Value = Sedenion::GetInstance(Base::Input(L"Value = "));
			Base::Output(to_wstring(std::invoke(Subroutine, Value)));
		}
	};
	template <typename F = Sedenion(SEDEN_FUNC_CALL*)(const Sedenion&, bool, std::int64_t)>
	inline void arctri(const std::wstring& LeftValue, std::wstring&& RightValue, F Subroutine)
	{
		if (LeftValue == RightValue)
		{
			Sedenion Value = Sedenion::GetInstance(Base::Input(L"Value = "));
			bool Sign = false;
			std::wstring Input = std::regex_replace(Base::Input(L"Sign : "), std::wregex(L" "), L"");
			if (Input == L"+") { Sign = true; }
			else if (Input != L"-") { throw_now(std::invalid_argument("A string interpretation of the sign cannot be converted as a bool value.")); }
			std::int64_t Period = ParseAsInteger(Base::Input(L"Period = "));
			Base::Output(to_wstring(std::invoke(Subroutine, Value, Sign, Period)));
		}
		else if (LeftValue == RightValue + L"()")
		{
			Sedenion Value = Sedenion::GetInstance(Base::Input(L"Value = "));
			std::int64_t PeriodMin = ParseAsInteger(Base::Input(L"PeriodMin = "));
			std::int64_t PeriodMax = ParseAsInteger(Base::Input(L"PeriodMax = "));
			for (std::int64_t Period = PeriodMin; Period <= PeriodMax; ++Period)
			{
				Base::Output(RightValue + L"(+, " + to_wstring(Period) + L") = ", to_wstring(std::invoke(Subroutine, Value, true, Period)));
			}
			for (std::int64_t Period = PeriodMin; Period <= PeriodMax; ++Period)
			{
				Base::Output(RightValue + L"(-, " + to_wstring(Period) + L") = ", to_wstring(std::invoke(Subroutine, Value, false, Period)));
			}
		}
	};
	class SedenConsole final
	{
	private:
		constexpr SedenConsole() noexcept = delete;
		constexpr ~SedenConsole() noexcept = delete;
	public:
		static void Load() noexcept;
	};
	void SedenConsole::Load() noexcept
	{
		Base::Startup(Base::GetTitle());
		Base::Selection(L"=   +   -   *   /   ^   power()   root()   log()");
		Base::Selection(L"abs   arg()   conjg   sgn   inverse   exp   ln()   dot   outer   even   cross");
		Base::Selection(L"sin   cos   tan   csc   sec   cot   arcsin()   arccos()   arctan()   arccsc()   arcsec()   arccot()");
		Base::Selection(L"sinh   cosh   tanh   csch   sech   coth   arcsinh()   arccosh()   arctanh()   arccsch()   arcsech()   arccoth()");
		Base::Selection(Base::GetStartupLine());
		for (std::wstring Line; !Base::IsSwitchTo(Line); Line = Base::Input())
		{
			if (Line.empty()) { continue; }
			evaluate(
				[&]() -> void {
					op(Line, L"=", operator ==);
					op(Line, L"+", operator +);
					op(Line, L"-", operator -);
					op(Line, L"*", operator *);
					op(Line, L"/", operator /);
					/****/
					power(Line, L"^", operator ^);
					power(Line, L"power", Sedenion::power);
					power(Line, L"root", Sedenion::root);
					power(Line, L"log", Sedenion::log);
					/****/
					basic(Line, L"abs", Sedenion::abs);
					basic(Line, L"arg", Sedenion::arg);
					basic(Line, L"conjg", Sedenion::conjg);
					basic(Line, L"sgn", Sedenion::sgn);
					basic(Line, L"inverse", Sedenion::inverse);
					basic(Line, L"exp", Sedenion::exp);
					basic(Line, L"ln", Sedenion::ln);
					multiple(Line, L"dot", Sedenion::dot);
					multiple(Line, L"outer", Sedenion::outer);
					multiple(Line, L"even", Sedenion::even);
					multiple(Line, L"cross", Sedenion::cross);
					/****/
					tri(Line, L"sin", Sedenion::sin);
					tri(Line, L"cos", Sedenion::cos);
					tri(Line, L"tan", Sedenion::tan);
					tri(Line, L"csc", Sedenion::csc);
					tri(Line, L"sec", Sedenion::sec);
					tri(Line, L"cot", Sedenion::cot);
					tri(Line, L"sinh", Sedenion::sinh);
					tri(Line, L"cosh", Sedenion::cosh);
					tri(Line, L"tanh", Sedenion::tanh);
					tri(Line, L"csch", Sedenion::csch);
					tri(Line, L"sech", Sedenion::sech);
					tri(Line, L"coth", Sedenion::coth);
					arctri(Line, L"arcsin", Sedenion::arcsin);
					arctri(Line, L"arccos", Sedenion::arccos);
					arctri(Line, L"arctan", Sedenion::arctan);
					arctri(Line, L"arccsc", Sedenion::arccsc);
					arctri(Line, L"arcsec", Sedenion::arcsec);
					arctri(Line, L"arccot", Sedenion::arccot);
					arctri(Line, L"arcsinh", Sedenion::arcsinh);
					arctri(Line, L"arccosh", Sedenion::arccosh);
					arctri(Line, L"arctanh", Sedenion::arctanh);
					arctri(Line, L"arccsch", Sedenion::arccsch);
					arctri(Line, L"arcsech", Sedenion::arcsech);
					arctri(Line, L"arccoth", Sedenion::arccoth);
				},
				[](const std::exception& ex) -> void { Base::Exception(ex); }
			);
		}
	};
}
