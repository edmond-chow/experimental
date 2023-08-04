#include <emscripten.h>
#include <emscripten/bind.h>
#include <string>
#include "Module.h"
#include "Module2.h"
#include "Module3.h"
#include "Base Extension.h"
using namespace CmplxConExt;
namespace ComplexTestingConsole
{
	EM_ASYNC_JS(void, readWrapper, (), {
		let line = await read();
		writeLine(line);
		document.querySelector('body > console')?.setAttribute('read', line);
		window.scrollTo(window.scrollX, document.body.scrollHeight);
	});
	class Base final
	{
	private:
		constexpr Base() noexcept = delete;
		constexpr ~Base() noexcept = delete;
		///
		/// Base
		///
		static constexpr const wchar_t* TestingConsole[] { L"Exit", L"Complex Testing Console", L"Quaternion Testing Console", L"Octonion Testing Console" };
		static std::size_t Index;
	public:
		static std::wstring GetTitle();
		static std::wstring GetStartupLine();
		static bool IsSwitchTo(const std::wstring& Str);
		///
		/// Main Thread
		///
		static void Main();
		///
		/// Console Line Materials
		///
		static std::wstring Exception(const std::wstring& type, const std::wstring& what);
		static std::wstring Exception();
		static std::wstring Selection(const std::wstring& str);
		static std::wstring Selection();
		static std::wstring Input(const std::wstring& str);
		static std::wstring Input();
		static std::wstring Output(const std::wstring& main, const std::wstring& str);
		static std::wstring Output(const std::wstring& str);
		static std::wstring Output();
		static std::wstring Comment(const std::wstring& head, const std::wstring& str);
		static std::wstring Comment(const std::wstring& str);
		static std::wstring Comment();
		static void Startup(const std::wstring& title);
	};
	///
	/// Base
	///
	std::size_t Base::Index = std::extent_v<decltype(Base::TestingConsole)> - 1;
	std::wstring Base::GetTitle() { return TestingConsole[Index]; };
	std::wstring Base::GetStartupLine()
	{
		std::wstring Output = L" >> ";
		for (const wchar_t* Name : TestingConsole)
		{
			if (std::wstring(Name) == TestingConsole[0]) { continue; }
			Output.append(L"[").append(Name).append(L"]   ");
		}
		return Output.substr(0, Output.length() - 3);
	};
	bool Base::IsSwitchTo(const std::wstring& Str)
	{
		for (std::size_t s = 0; s < std::extent_v<decltype(TestingConsole)>; ++s)
		{
			if (Str == std::wstring{}.append(L"[").append(TestingConsole[s]).append(L"]"))
			{
				Index = s;
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
		while (true)
		{
			switch (Index)
			{
			case 0:
				clear();
				return;
			case 1:
				Mod::MyModule::Load();
				break;
			case 2:
				Mod2::MyModule2::Load();
				break;
			case 3:
				Mod3::MyModule3::Load();
				break;
			default:
				throw;
			}
		}
	};
	///
	/// Console Line Materials
	///
	std::wstring Base::Exception(const std::wstring& type, const std::wstring& what)
	{
		setForegroundColor(ConsoleColor::DarkCyan);
		writeLine(L"");
		write(L"   [");
		write(type);
		write(L"] ");
		setForegroundColor(ConsoleColor::Cyan);
		write(what);
		writeLine(L"");
		setForegroundColor(ConsoleColor::White);
		writeLine(L"   Press any key to continue . . .   ");
		pressAnyKey();
		writeLine(L"");
		return L"";
	};
	std::wstring Base::Exception() { return Exception(L"", L""); };
	std::wstring Base::Selection(const std::wstring& str)
	{
		setForegroundColor(ConsoleColor::DarkCyan);
		write(L" %   ");
		setForegroundColor(ConsoleColor::Blue);
		write(str);
		writeLine(L"");
		return str;
	};
	std::wstring Base::Selection() { return Selection(L""); };
	std::wstring Base::Input(const std::wstring& str)
	{
		setForegroundColor(ConsoleColor::Yellow);
		write(L" >   ");
		setForegroundColor(ConsoleColor::DarkGreen);
		write(str);
		setForegroundColor(ConsoleColor::Green);
		readWrapper();
		return resolveReaded();
	};
	std::wstring Base::Input() { return Input(L""); };
	std::wstring Base::Output(const std::wstring& main, const std::wstring& str)
	{
		setForegroundColor(ConsoleColor::Magenta);
		write(L" #   ");
		setForegroundColor(ConsoleColor::DarkRed);
		write(main);
		setForegroundColor(ConsoleColor::Red);
		write(str);
		writeLine(L"");
		return str;
	};
	std::wstring Base::Output(const std::wstring& str) { return Output(L"", str); };
	std::wstring Base::Output() { return Output(L""); };
	std::wstring Base::Comment(const std::wstring& head, const std::wstring& str)
	{
		setForegroundColor(ConsoleColor::White);
		write(L" /   ");
		setForegroundColor(ConsoleColor::Cyan);
		write(head);
		setForegroundColor(ConsoleColor::Gray);
		write(str);
		writeLine(L"");
		return str;
	};
	std::wstring Base::Comment(const std::wstring& str) { return Comment(L"", str); };
	std::wstring Base::Comment() { return Comment(L""); };
	void Base::Startup(const std::wstring& title)
	{
		clear();
		setTitle(title);
		writeLine(L"");
	};
}
