#include <string>
inline std::string ToMbsString(const std::wstring& String)
{
	std::size_t Length = String.size() * sizeof(wchar_t) + 1;
	char* Temporary = new char[Length] { '\0' };
	std::wcstombs(Temporary, String.c_str(), Length);
	std::string Converted = Temporary;
	delete[] Temporary;
	return Converted;
};
inline std::wstring ToWcsString(const std::string& String)
{
	std::size_t Length = String.size() + 1;
	wchar_t* Temporary = new wchar_t[Length] { L'\0' };
	std::mbstowcs(Temporary, String.c_str(), Length);
	std::wstring Converted = Temporary;
	delete[] Temporary;
	return Converted;
};
