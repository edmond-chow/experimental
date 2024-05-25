#include <iostream>
#include <streambuf>
#include <sstream>
struct client_t : public std::wstringbuf
{
    std::size_t lines;
    client_t() : lines{ 0 }, std::wstringbuf{} {};
    virtual std::streamsize xsputn(const wchar_t* p, std::streamsize s) override
    {
        if (lines >= 3)
        {
            std::wcout << this->str();
            this->str(L"");
            lines = 0;
        }
        for (std::streamsize i = 0; i < s; ++i)
        {
            if (p[i] == L'\n') { ++lines; }
        }
        return this->std::wstreambuf::xsputn(p, s);
    };
};
int main()
{
    client_t client{};
    std::wostream out{ &client };
    out << std::endl;
    out << L"qwertyu" << std::endl << "asd" << std::endl << "artyud" << std::endl << "\n\n\n";
    std::wcout << client.str();
};