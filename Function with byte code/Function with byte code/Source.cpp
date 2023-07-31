#include <string>
#include <iostream>
#include <stdint.h>
#pragma section("__sec", read, execute)
#ifndef _WIN64
static constexpr const uint8_t __declspec(allocate("__sec")) func[]
{
    0x55,
    0x8B, 0xEC,
    0x8B, 0x45, 0x08,
    0x40,
    0x5D,
    0xC3,
};
#else
static constexpr const uint8_t __declspec(allocate("__sec")) func[]
{
    0x8D, 0x41, 0x01,
    0xC3,
};
#endif
// int __cdecl inc(int n) { return n + 1; };
int main()
{
    union u { const uint8_t* __data; int(__cdecl* inc_f)(int); } __u{ 0 };
    __u.__data = func;
    std::cout << __u.inc_f(9) << std::endl;
    std::string line;
    std::getline(std::cin, line);
};