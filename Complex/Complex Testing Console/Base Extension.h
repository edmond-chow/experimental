#pragma once
/* ============= */
/*               */
/*   Extension   */
/*               */
/* ============= */
#include <string>
namespace CmplxConExt
{
	std::string toMbsString(const std::wstring& string);
	std::wstring toWcsString(const std::string& string);
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
	ConsoleColor getForegroundColor();
	ConsoleColor getBackgroundColor();
	std::wstring getTitle();
	void setForegroundColor(ConsoleColor color);
	void setBackgroundColor(ConsoleColor color);
	void setTitle(const std::wstring& title);
	void clear();
	void pressAnyKey();
	template <typename T>
	inline void write(const T& content) {
		void write(const void* content, bool wide);
		if constexpr (std::is_same_v<T, std::string>)
		{
			write(&content, false);
		}
		else if (std::is_same_v<T, std::wstring>)
		{
			write(&content, true);
		}
	};
	void read();
}
