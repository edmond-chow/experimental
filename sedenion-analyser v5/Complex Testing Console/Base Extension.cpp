/* ============= */
/*               */
/*   Extension   */
/*               */
/* ============= */
#include <emscripten.h>
#include <cstdlib>
#include <cstdint>
#include <string>
#include <sstream>
#include <stdexcept>
#include <streambuf>
#include "Base.h"
namespace CmplxConExt
{
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
	namespace dom
	{
		namespace native
		{
			EM_JS(std::uint8_t, foreground, (), {
				return iostream.getForegroundColor().toConsoleColor();
			});
			EM_JS(std::uint8_t, background, (), {
				return iostream.getBackgroundColor().toConsoleColor();
			});
			EM_JS(const wchar_t*, title, (), {
				return getUTF32String(title, getTitle());
			});
			EM_JS(std::char_traits<wchar_t>::int_type, color_char_code, (std::uint8_t code), {
				return Console.GetColorCharCode(code);
			});
			EM_ASYNC_JS(wchar_t*, read_line, (), {
				let line = await iostream.readLine();
				await iostream.writeLine(line, false);
				return getUTF32String(__asyncjs__read_line, line);
			});
			EM_ASYNC_JS(void, write_code, (const wchar_t* content), {
				await iostream.write(UTF32ToString(content));
			});
			EM_ASYNC_JS(void, press_any_key, (), {
				await iostream.pressAnyKey();
			});
			EM_JS(void, clear, (), {
				iostream.clear();
			});
		}
		struct js_console
		{
		private:
			explicit js_console(const js_console&) = delete;
			explicit js_console(js_console&&) = delete;
			explicit js_console() = delete;
		public:
			static wchar_t color_char_code(std::uint8_t code)
			{
				return std::char_traits<wchar_t>::to_char_type(native::color_char_code(code));
			};
			static std::uint8_t* foreground()
			{
				static std::uint8_t data = native::foreground();
				return &data;
			};
			static std::uint8_t* background()
			{
				static std::uint8_t data = native::background();
				return &data;
			};
			static std::wstring* title()
			{
				static std::wstring data = native::title();
				return &data;
			};
			static wchar_t* read_line()
			{
				return native::read_line();
			};
			static void write_code(const wchar_t* content)
			{
				return native::write_code(content);
			};
			static void press_any_key()
			{
				return native::press_any_key();
			};
			static void clear()
			{
				native::clear();
			};
		};
		struct client_stream : public std::wstreambuf
		{
		private:
			static constexpr const std::size_t out_sz = 32768;
			enum class state
			{
				pending = 1,
				write_sync = 2,
			};
			state state;
			char_type out[out_sz];
			char_type* out_last_ln;
		public:
			client_stream() : state{ state::pending }, out{}, out_last_ln{ nullptr }
			{
				setp(out, out + out_sz - 2);
			};
		protected:
			virtual int sync() override
			{
				if (state == state::write_sync)
				{
					char_type* end_out = out_last_ln == nullptr ? pptr() : out_last_ln;
					*end_out = L'\0';
					js_console::write_code(out);
					pbump(out - pptr());
					int end_off = pptr() - end_out;
					if (end_off > 0)
					{
						*end_out = L'\n';
						std::memmove(out, end_out, end_off);
						pbump(end_off);
					}
					state = state::pending;
				}
				return 0;
			};
		public:
			int send()
			{
				if (state == state::pending) { state = state::write_sync; }
				return sync();
			};
		protected:
			virtual int_type overflow(int_type ch) override
			{
				if (ch != traits_type::eof())
				{
					*pptr() = traits_type::to_char_type(ch);
					if (traits_type::to_char_type(ch) == L'\n') { out_last_ln = pptr(); }
					pbump(1);
				}
				send();
				return ch;
			};
			virtual int_type underflow() override
			{
				send();
				if (gptr() == egptr())
				{
					char_type* in = js_console::read_line();
					std::size_t in_sz = wcslen(in);
					setg(in, in, in + in_sz + 1);
					in[in_sz] = L'\n';
				}
				return traits_type::to_int_type(*gptr());
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
		dom::wcout << L"\\f" << dom::js_console::color_char_code(static_cast<std::uint8_t>(Color)) << L"\\";
	};
	void SetBackgroundColor(ConsoleColor Color)
	{
		*dom::js_console::background() = static_cast<std::uint8_t>(Color);
		dom::wcout << L"\\b" << dom::js_console::color_char_code(static_cast<std::uint8_t>(Color)) << L"\\";
	};
	void SetTitle(const std::wstring& Text)
	{
		*dom::js_console::title() = Text;
		dom::wcout << L"\\t" << Text << L"\\";
	};
	void PressAnyKey()
	{
		dom::client.send();
		dom::js_console::press_any_key();
	};
	void Clear()
	{
		dom::client.send();
		dom::js_console::clear();
	};
}
int main()
{
	ComplexTestingConsole::Base::Main();
	return EXIT_SUCCESS;
};
