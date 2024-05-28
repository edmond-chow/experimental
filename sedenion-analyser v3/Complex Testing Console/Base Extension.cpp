/* ============= */
/*               */
/*   Extension   */
/*               */
/* ============= */
#include <emscripten.h>
#include <cstdlib>
#include <cstdint>
#include <string>
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
			static constexpr const std::streamsize out_sz = 1024;
			wchar_t out[out_sz];
			wchar_t in_pop;
			bool rd_in;
		public:
			client_stream() : out{}, in_pop{ L'\n' }, rd_in{ false }
			{
				setg(nullptr, nullptr, nullptr);
				setp(out, out + out_sz - 2);
			};
		protected:
			virtual int sync() override
			{
				*pptr() = L'\0';
				js_console::write_code(out);
				setp(out, out + out_sz - 2);
				*pptr() = L'\0';
				return 0;
			};
		protected:
			virtual std::streamsize xsputn(const char_type* s, std::streamsize count) override
			{
				std::ptrdiff_t out_av = epptr() - pptr();
				out_av = count <= out_av ? count : out_av;
				std::copy(s, s + out_av, pptr());
				pbump(out_av);
				return out_av;
			};
			virtual int_type overflow(int_type ch) override
			{
				if (ch != std::char_traits<wchar_t>::eof())
				{
					*pptr() = std::char_traits<wchar_t>::to_char_type(ch);
					pbump(1);
					sync();
				}
				return ch;
			};
			virtual std::streamsize xsgetn(char_type* s, std::streamsize count) override
			{
				std::ptrdiff_t in_av = egptr() - gptr();
				in_av = count <= in_av ? count : in_av;
				std::copy(gptr(), gptr() + in_av, s);
				gbump(in_av);
				return in_av;
			};
			virtual int_type underflow() override
			{
				bool end_up = rd_in;
				if (!rd_in)
				{
					sync();
					wchar_t* in = js_console::read_line();
					std::size_t in_sz = wcslen(in);
					if (in_sz > 0)
					{
						setg(in, in, in + in_sz);
						rd_in = true;
					}
					else
					{
						end_up = true;
					}
				}
				if (end_up)
				{
					setg(&in_pop, &in_pop, &in_pop + 1);
					rd_in = false;
				}
				return std::char_traits<wchar_t>::to_int_type(*gptr());
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
		dom::client.pubsync();
		dom::js_console::press_any_key();
	};
	void Clear()
	{
		dom::client.pubsync();
		dom::js_console::clear();
	};
}
int main()
{
	ComplexTestingConsole::Base::Main();
	return EXIT_SUCCESS;
};
