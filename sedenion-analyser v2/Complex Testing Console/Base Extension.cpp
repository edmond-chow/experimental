/* ============= */
/*               */
/*   Extension   */
/*               */
/* ============= */
#include <emscripten.h>
#include <emscripten/val.h>
#ifndef __EMSCRIPTEN__
#include "emscripten/val.h"
#endif
#include <iostream>

#include <cstdlib>
#include <cstdint>
#include <string>
#include <sstream>
#include <stdexcept>
#include <streambuf>
#include <coroutine>
#include "Base.h"
namespace CmplxConExt
{
	namespace Native
	{
		EM_ASYNC_JS(const wchar_t*, ReadSync, (), {
			let line = await iostream.readLine();
			await iostream.writeLine(line, false);
			return getUTF32String(__asyncjs__ReadSync, line);
		});
		EM_ASYNC_JS(void, WriteSync, (const wchar_t* Content), {
			await iostream.write(UTF32ToString(Content));
		});
		EM_ASYNC_JS(void, NativePressAnyKey, (), {
			await iostream.pressAnyKey();
		});
	}
	enum class ConsoleColor : std::uint8_t
	{
		Default = 0xff,
		Black = 0,
		DarkBlue = 1,
		DarkGreen = 2,
		DarkCyan = 3,
		DarkRed = 4,
		DarkMagenta = 5,
		DarkYellow = 6,
		Gray = 7,
		DarkGray = 8,
		Blue = 9,
		Green = 10,
		Cyan = 11,
		Red = 12,
		Magenta = 13,
		Yellow = 14,
		White = 15,
	};
	std::wstring ReadSync()
	{
		return Native::ReadSync();
	};
	void WriteSync(const std::wstring& Content)
	{
		Native::WriteSync(Content.c_str());
	};
	void NativePressAnyKey()
	{
		Native::NativePressAnyKey();
	};
	namespace dom
	{
		struct js_console
		{
		private:
			explicit js_console() = delete;
		public:
			static emscripten::val* window()
			{
				thread_local emscripten::val window = emscripten::val::global("window");
				return &window;
			};
			static emscripten::val* console()
			{
				thread_local emscripten::val iostream = emscripten::val::global("Console");
				return &iostream;
			};
			static emscripten::val* iostream()
			{
				thread_local emscripten::val iostream = emscripten::val::global("iostream");
				return &iostream;
			};
			static void clear()
			{
				iostream()->call<void>("clear");
			};
			static std::uint8_t* foreground()
			{
				thread_local std::uint8_t data = []() -> std::uint8_t {
					std::string color = iostream()->call<std::string>("getForegroundColor");
					return emscripten::val::u8string(color.c_str()).call<std::uint8_t>("toConsoleColor");
				}();
				return &data;
			};
			static std::uint8_t* background()
			{
				thread_local std::uint8_t data = []() -> std::uint8_t {
					std::string color = iostream()->call<std::string>("getBackgroundColor");
					return emscripten::val::u8string(color.c_str()).call<std::uint8_t>("toConsoleColor");
				}();
				return &data;
			};
			static std::wstring* title()
			{
				thread_local std::wstring data = window()->call<std::wstring>("getTitle");
				return &data;
			};
			static wchar_t get_color_char_code(std::uint8_t code)
			{
				return std::char_traits<wchar_t>::to_char_type(console()->call<std::uint8_t>("GetColorCharCode", code));
			};
			static emscripten::val press_any_key()
			{
				return iostream()->call<emscripten::val>("pressAnyKey").await();
			};
		};
		struct client_stream : public std::wstreambuf
		{
		private:
			static constexpr const std::size_t out_lm = 1024;
			enum class state
			{
				write = 1,
				freeze = 2,
				read = 3,
			};
			state state;
			std::wstringstream out;
			std::size_t out_l;
			std::wstring in;
			std::wstring::const_iterator in_cur;
			wchar_t in_pop;
		public:
			explicit client_stream() : state { state::freeze }, out{}, out_l{}, in{}, in_cur{}, in_pop{} {};
		protected:
			virtual int sync() override
			{
				if (state == state::read) { return -1; }
				if (state == state::write)
				{
					WriteSync(out.str());
					out.str(L"");
					out_l = 0;
					state = state::freeze;
				}
				return 0;
			};
		public:
			int send()
			{
				if (state == state::freeze) { state = state::write; }
				return sync();
			};
		protected:
			virtual int_type overflow(int_type c) override
			{
				if (state == state::read) { return std::char_traits<wchar_t>::eof(); }
				if (out_l >= out_lm) { send(); }
				if (c == std::char_traits<wchar_t>::to_int_type(L'\n')) { ++out_l; }
				out << std::char_traits<wchar_t>::to_char_type(c);
				return c;
			};
			virtual int_type underflow() override
			{
				send();
				if (state == state::freeze)
				{
					in = ReadSync();
					in_cur = in.cbegin();
					state = state::read;
				}
				setg(&in_pop, &in_pop, &in_pop + 1);
				if (in_cur == in.cend())
				{
					in_pop = L'\n';
					state = state::freeze;
				}
				else
				{
					in_pop = *in_cur;
					++in_cur;
				}
				return std::char_traits<wchar_t>::to_int_type(in_pop);
			};
		};
		static client_stream client{};
		std::wistream wcin{ &client };
		std::wostream wcout{ &client };
	}
	ConsoleColor GetForegroundColor()
	{
		return static_cast<ConsoleColor>(*dom::js_console::foreground());
	};
	ConsoleColor GetBackgroundColor()
	{
		return static_cast<ConsoleColor>(*dom::js_console::background());
	};
	std::wstring GetTitle()
	{
		return *dom::js_console::title();
	};
	void SetForegroundColor(ConsoleColor Color)
	{
		*dom::js_console::foreground() = static_cast<std::uint8_t>(Color);
		dom::wcout << L"\\f" << dom::js_console::get_color_char_code(static_cast<std::uint8_t>(Color)) << L"\\";
	};
	void SetBackgroundColor(ConsoleColor Color)
	{
		*dom::js_console::background() = static_cast<std::uint8_t>(Color);
		dom::wcout << L"\\b" << dom::js_console::get_color_char_code(static_cast<std::uint8_t>(Color)) << L"\\";
	};
	void SetTitle(const std::wstring& Text)
	{
		*dom::js_console::title() = Text;
		dom::wcout << L"\\t" << Text << L"\\";
	};
	void Clear()
	{
		dom::client.send();
		dom::js_console::clear();
	};
	void PressAnyKey()
	{
		dom::client.send();
		dom::js_console::press_any_key();
	};
}
int main()
{
	ComplexTestingConsole::Base::Main();
	return EXIT_SUCCESS;
};
