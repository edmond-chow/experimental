#include <string>
#include <iostream>
#include <cmath>
int main()
{
    std::wcout << std::to_wstring(std::pow(243, 0.2)) << std::endl;
    // 3.000000
    std::wcout << std::to_wstring(std::pow(-243, 0.2)) << std::endl;
    // -nan(ind)
    return 0;
};