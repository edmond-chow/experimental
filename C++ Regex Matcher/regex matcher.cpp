#include <iostream>
#include <string>
#include <regex>
int main()
{
    std::wstring s = L"12&345&#89&#1&74&324&#";
    std::wsmatch match;
    std::wregex regex(LR"(((\d+&)+#)+)");
    bool success = std::regex_match(s, match, regex);
    if (success) {
        auto& i0 = match.operator[](0);
        std::wstring str0 = match.str(0);
        auto& i1 = match.operator[](1);
        std::wstring str1 = match.str(1);
        auto& i2 = match.operator[](2);
        std::wstring str2 = match.str(2);

    }

    std::cout << "Hello World!\n";
}