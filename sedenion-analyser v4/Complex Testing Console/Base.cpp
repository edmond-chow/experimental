﻿#include <string>
#include <stdexcept>
#include <iostream>
#include "Complex Testing Console.h"
#include "Quaternion Testing Console.h"
#include "Octonion Testing Console.h"
#include "Sedenion Extended Module.h"
#include "Base Extension.h"
using namespace CmplxConExt;
namespace ComplexTestingConsole
{
	class Base final
	{
	private:
		constexpr Base() noexcept = delete;
		constexpr ~Base() noexcept = delete;
		///
		/// Base
		///
		static constexpr const wchar_t* const Alternative[] { L"Exit", L"Complex Testing Console", L"Quaternion Testing Console", L"Octonion Testing Console", L"Sedenion Extended Module" };
		static constexpr void(*const Subroutine[])() { nullptr, CmplxBasis::CmplxConsole::Load, QuterBasis::QuterConsole::Load, OctonBasis::OctonConsole::Load, SedenBasis::SedenConsole::Load };
		static constexpr const std::size_t HiddenLength = 1;
		static constexpr const std::size_t DefaultIndex = 3;
		static std::size_t Index;
		static std::wstring AddSquares(const std::wstring& Option) { return L"[" + Option + L"]"; };
	public:
		static std::wstring GetTitle();
		static std::wstring GetStartupLine();
		static bool IsSwitchTo(const std::wstring& Option);
		///
		/// Main Thread
		///
		static void Main();
		///
		/// Console Line Materials
		///
		static std::wstring Exception(const std::exception& Exception);
		static std::wstring Exception();
		static std::wstring Selection(const std::wstring& Content);
		static std::wstring Selection();
		static std::wstring Input(const std::wstring& Content);
		static std::wstring Input();
		static std::wstring Output(const std::wstring& Preceding, const std::wstring& Content);
		static std::wstring Output(const std::wstring& Content);
		static std::wstring Output();
		static std::wstring Comment(const std::wstring& Preceding, const std::wstring& Content);
		static std::wstring Comment(const std::wstring& Content);
		static std::wstring Comment();
		static void Startup(const std::wstring& Title);
	};
	///
	/// Base
	///
	std::size_t Base::Index = DefaultIndex;
	std::wstring Base::GetTitle()
	{
		return Index > DefaultIndex ? L"Extended Module (Sedenion, Pathion, Chingon, Routon, Voudon, ...)" : Alternative[Index];
	};
	std::wstring Base::GetStartupLine()
	{
		std::wstring Result = L" >> ";
		bool First = true;
		for (std::size_t i = HiddenLength; i < std::extent_v<decltype(Alternative)>; ++i, First = false)
		{
			if (First == false) { Result += L"   "; }
			Result += AddSquares(Alternative[i]);
		}
		return Result;
	};
	bool Base::IsSwitchTo(const std::wstring& Option)
	{
		for (std::size_t i = 0; i < std::extent_v<decltype(Alternative)>; ++i)
		{
			if (Option == AddSquares(Alternative[i]))
			{
				Index = i;
				return true;
			}
		}
		return false;
	};
	///
	/// Main Thread
	///
	void Base::Main()
	{
		while (Subroutine[Index] != nullptr)
		{
			Subroutine[Index]();
		}
		Index = DefaultIndex;
		Clear();
	};
	///
	/// Console Line Materials
	///
	std::wstring Base::Exception(const std::exception& Exception)
	{
		SetForegroundColor(ConsoleColor::DarkCyan);
		dom::wcout << std::endl << L"   [" << typeid(Exception).name() << L"] ";
		SetForegroundColor(ConsoleColor::Cyan);
		dom::wcout << Exception.what() << std::endl;
		SetForegroundColor(ConsoleColor::White);
		dom::wcout << L"   Press any key to continue . . .   " << std::endl;
		PressAnyKey();
		dom::wcout << std::endl;
		return L"";
	};
	std::wstring Base::Exception() { return Exception(std::exception()); };
	std::wstring Base::Selection(const std::wstring& Content)
	{
		SetForegroundColor(ConsoleColor::DarkCyan);
		dom::wcout << L" %   ";
		SetForegroundColor(ConsoleColor::Blue);
		dom::wcout << Content << std::endl;
		return Content;
	};
	std::wstring Base::Selection() { return Selection(L""); };
	std::wstring Base::Input(const std::wstring& Content)
	{
		SetForegroundColor(ConsoleColor::Yellow);
		dom::wcout << L" >   ";
		SetForegroundColor(ConsoleColor::DarkGreen);
		dom::wcout << Content;
		SetForegroundColor(ConsoleColor::Green);
		std::wstring output;
		std::getline(dom::wcin, output);
		return output;
	};
	std::wstring Base::Input() { return Input(L""); };
	std::wstring Base::Output(const std::wstring& Preceding, const std::wstring& Content)
	{
		SetForegroundColor(ConsoleColor::Magenta);
		dom::wcout << L" #   ";
		SetForegroundColor(ConsoleColor::DarkRed);
		dom::wcout << Preceding;
		SetForegroundColor(ConsoleColor::Red);
		dom::wcout << Content << std::endl;
		return Content;
	};
	std::wstring Base::Output(const std::wstring& Content) { return Output(L"", Content); };
	std::wstring Base::Output() { return Output(L""); };
	std::wstring Base::Comment(const std::wstring& Preceding, const std::wstring& Content)
	{
		SetForegroundColor(ConsoleColor::White);
		dom::wcout << L" /   ";
		SetForegroundColor(ConsoleColor::Cyan);
		dom::wcout << Preceding;
		SetForegroundColor(ConsoleColor::Gray);
		dom::wcout << Content << std::endl;
		return Content;
	};
	std::wstring Base::Comment(const std::wstring& Content) { return Comment(L"", Content); };
	std::wstring Base::Comment() { return Comment(L""); };
	void Base::Startup(const std::wstring& Title)
	{
		Clear();
		SetTitle(Title);
		dom::wcout << std::endl;
	};
}
