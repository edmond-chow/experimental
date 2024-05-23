#include <iostream>
#include <string>
struct MyStruct
{
private:
    std::uint8_t* ptr;
    size_t s_t;
public:
    constexpr MyStruct(const size_t s_t) : ptr(new std::uint8_t[s_t]{}), s_t(s_t) { std::fill_n(ptr, s_t, 0xCC); };
    constexpr ~MyStruct() { delete[] ptr; };
    constexpr const std::uint8_t* data() const { return ptr; }
    constexpr const size_t size() const { return s_t; }
};
constexpr size_t f()
{
    return MyStruct(100).size();
};
constexpr const std::uint8_t g(const ptrdiff_t diff_t)
{
    return MyStruct(100).data()[diff_t];
};
int main()
{
    constexpr std::uint8_t s = g(99);
    std::cout << (size_t)s << std::endl;
    std::string line;
    std::getline(std::cin, line);
};