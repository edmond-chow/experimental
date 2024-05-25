#include <iostream>
#include <string>
#include <functional>
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
constexpr const std::uint8_t g(const MyStruct& s, const ptrdiff_t diff_t)
{
    const std::uint8_t ret = s.data()[diff_t];
    return ret;
};
constexpr int a(const int& b)
{
    return b;
};
int main()
{
    auto /*std::function<void(int, double)>*/ t = [](int i, double d) { std::cout << i << std::endl << d << std::endl; };
    std::function<void(double, int)> f = std::bind(t, std::placeholders::_2, std::placeholders::_1);
    //constexpr int& a = 9;
    constexpr int c = a(8);
    constexpr std::uint8_t s = g(MyStruct(100), 9);
    static_assert(s == 0xCC);
    std::cout << (size_t)s << std::endl;
    std::string line;
    std::getline(std::cin, line);
};
