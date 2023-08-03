/* ============= */
/*               */
/*   Extension   */
/*               */
/* ============= */
#include <emscripten.h>
#include <cstdlib>
#include <string>
#include <iostream>
#pragma push_macro("max")
#undef max
#include "Base.h"
#pragma pop_macro("max")
namespace CmplxConExt
{
	std::string toMbsString(const std::wstring& string)
	{
		std::size_t length = string.size() * 5 + 1;
		char* temporary = new char[length] { '\0' };
		std::wcstombs(temporary, string.c_str(), length);
		std::string converted = temporary;
		delete[] temporary;
		return converted;
	};
	std::wstring toWcsString(const std::string& string)
	{
		std::size_t length = string.size() * 5 + 1;
		wchar_t* temporary = new wchar_t[length] { '\0' };
		std::mbstowcs(temporary, string.c_str(), length);
		std::wstring converted = temporary;
		delete[] temporary;
		return converted;
	};
	enum class ConsoleColor : std::uint8_t
	{
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
	static const char* ConsoleColorList[] {
		"black",
		"dark-blue",
		"dark-green",
		"dark-cyan",
		"dark-red",
		"dark-magenta",
		"dark-yellow",
		"gray",
		"dark-gray",
		"blue",
		"green",
		"cyan",
		"red",
		"magenta",
		"yellow",
		"white",
	};
	inline ConsoleColor toConsoleColor(const char* output) {
		for (std::size_t i = 0; i < std::extent_v<decltype(ConsoleColorList)>; ++i) {
			if (std::strcmp(output, ConsoleColorList[i]) == 0) {
				return static_cast<ConsoleColor>(i);
			}
		}
		return static_cast<ConsoleColor>(0);
	};
	inline const char* toStringLiteral(ConsoleColor input) {
		return ConsoleColorList[static_cast<std::size_t>(input) % std::extent_v<decltype(ConsoleColorList)>];
	};
	ConsoleColor getForegroundColor()
	{
		return toConsoleColor(emscripten_run_script_string("getForegroundColor()"));
	};
	ConsoleColor getBackgroundColor()
	{
		return toConsoleColor(emscripten_run_script_string("getBackgroundColor()"));
	};
	std::wstring getTitle()
	{
		return toWcsString(emscripten_run_script_string("getTitle()"));
	};
	void setForegroundColor(ConsoleColor color)
	{
		char call[] = "setForegroundColor(\"             )";
		const char* output = toStringLiteral(color);
		*(std::strcpy(&call[20], output) + std::strlen(output)) = '\"';
		emscripten_run_script(call);
	};
	void setBackgroundColor(ConsoleColor color)
	{
		char call[] = "setBackgroundColor(\"             )";
		const char* output = toStringLiteral(color);
		*(std::strcpy(&call[20], output) + std::strlen(output)) = '\"';
		emscripten_run_script(call);
	};
	void setTitle(const std::wstring& title)
	{
		std::string call = "setTitle(\"" + toMbsString(title) + "\")";
		emscripten_run_script(call.c_str());
	};
	void clear()
	{
		emscripten_run_script("clear()");
	};
	void pressAnyKey()
	{
		emscripten_run_script("pressAnyKey()");
	};
	void write(const void* content, bool wide) {
		std::string call = "write(\"" + (wide ? toMbsString(*reinterpret_cast<const std::wstring*>(content)) : *reinterpret_cast<const std::string*>(content)) + "\")";
		emscripten_run_script(call.c_str());
	};
	void read() {
		emscripten_run_script("read()");
	};
}
EMSCRIPTEN_KEEPALIVE
extern "C" int main()
{
	ComplexTestingConsole::Base::Main();
	return EXIT_SUCCESS;
};
