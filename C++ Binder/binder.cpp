#include <iostream>
#include <string>
#include <functional>
#include <tuple>
namespace my
{
    template <typename T>
    struct is_integral_constant : public std::false_type {};
    template <typename T, T n>
    struct is_integral_constant<std::integral_constant<T, n>> : public std::true_type {};
    template <typename T>
    inline constexpr bool is_integral_constant_v = is_integral_constant<T>::value;
    template <std::size_t n>
    inline constexpr std::integral_constant<std::size_t, n> place;
    template <typename T>
    struct is_place : public std::integral_constant<std::size_t, 0> {};
    template <std::size_t n>
    struct is_place<std::integral_constant<std::size_t, n>> : public std::integral_constant<std::size_t, n> {};
    template <int n>
    struct is_place<std::integral_constant<int, n>> : public std::integral_constant<std::size_t, static_cast<std::size_t>(n)> {};
    template <typename T>
    inline constexpr std::size_t is_place_v = is_place<T>::value;
    struct Unforced
    {
        explicit Unforced() = default;
    };
    template <typename Ret, bool = std::is_void_v<Ret>>
    struct binder_impl
    {
        template <typename Func, typename... Others>
        static constexpr Ret call(Func&& func, Others&&... others)
            noexcept(noexcept(std::invoke(std::move(func), std::move(others)...)))
        {
            return std::invoke(std::move(func), std::move(others)...);
        };
    };
    template <typename Ret>
    struct binder_impl<Ret, true>
    {
        template <typename Func, typename... Others>
        static constexpr void call(Func&& func, Others&&... others)
            noexcept(noexcept(std::invoke(std::move(func), std::move(others)...)))
        {
            std::invoke(std::move(func), std::move(others)...);
        };
    };
    template <>
    struct binder_impl<Unforced, false>
    {
        template <typename Func, typename... Others>
        static constexpr auto call(Func&& func, Others&&... others)
            noexcept(noexcept(std::invoke(std::move(func), std::move(others)...)))
            -> decltype(std::invoke(std::move(func), std::move(others)...))
        {
            return std::invoke(std::move(func), std::move(others)...);
        };
    };
    template <typename A, template <typename...> typename T>
    inline constexpr bool is_specialization_v = false;
    template <template <typename...> typename T, typename... A>
    inline constexpr bool is_specialization_v<T<A...>, T> = true;
    template <typename A, template <typename...> typename T>
    struct is_specialization : public std::bool_constant<is_specialization_v<A, T>> {};
    template <typename Ret, typename Func, typename... Args>
    class binder;
    template <typename T>
    struct is_bind_expression : public std::false_type {};
    template <typename Ret, typename Func, typename... Args>
    struct is_bind_expression<binder<Ret, Func, Args...>> : public std::true_type {};
    template <typename T>
    inline constexpr bool is_bind_expression_v = is_bind_expression<T>::value;
    template <typename T, bool = is_specialization_v<std::decay_t<T>, std::reference_wrapper>, std::size_t = is_place_v<T>>
    struct fixer;
    template <typename T>
    struct fixer<T, false, 0>
    {
        template <typename OthersTuple>
        static constexpr T& fix(T& t, OthersTuple&& others) noexcept // identity fixer
        {
            return t;
        };
    };
    template <typename T, std::size_t n>
    struct fixer<T, false, n>
    {
        template <typename OthersTuple>
        static constexpr auto fix(T& t, OthersTuple&& others) noexcept -> decltype(std::get<n - 1>(others)) // placeholder fixer
        {
            return std::get<n - 1>(others);
        };
    };
    template <typename T>
    struct fixer<T, true, 0>
    {
        template <typename OthersTuple>
        static constexpr T::type& fix(T& t, OthersTuple&& others) noexcept // reference_wrapper fixer
        {
            return t.get();
        };
    };
    template <typename T, typename OthersTuple>
    constexpr auto fix_arg(T& t, OthersTuple&& others)
        noexcept(noexcept(fixer<T>::fix(t, std::move(others))))
        -> decltype(fixer<T>::fix(t, std::move(others)))
    {
        return fixer<T>::fix(t, std::move(others));
    };
    template <typename Ret, std::size_t... n, typename Func, typename ArgsTuple, typename OthersTuple>
    constexpr auto call_binder(binder_impl<Ret>, std::integer_sequence<std::size_t, n...>, Func& func, ArgsTuple& args, OthersTuple&& others)
        noexcept(noexcept(binder_impl<Ret>::call(func, fix_arg(std::get<n>(args), std::move(others))...)))
        -> decltype(binder_impl<Ret>::call(func, fix_arg(std::get<n>(args), std::move(others))...))
    {
        return binder_impl<Ret>::call(func, fix_arg(std::get<n>(args), std::move(others))...);
    };
    template <typename Ret, typename Func, typename... Args>
    class binder
    {
    private:
        std::decay_t<Func> func;
        std::tuple<std::decay_t<Args>...> args;
    public:
        binder(Func&& func, Args&&... args) : func(func), args(std::forward_as_tuple(args...)) {};
        template <typename... Others>
        constexpr auto operator ()(Others&&... others)
            noexcept(noexcept(call_binder(binder_impl<Ret>{}, std::index_sequence_for<Args...>{}, func, args, std::forward_as_tuple(others...))))
            -> decltype(call_binder(binder_impl<Ret>{}, std::index_sequence_for<Args...>{}, func, args, std::forward_as_tuple(others...)))
        {
            return call_binder(binder_impl<Ret>{}, std::index_sequence_for<Args...>{}, func, args, std::forward_as_tuple(others...));
        };
        template <typename... Others>
        constexpr auto operator ()(Others&&... others) const
            noexcept(noexcept(call_binder(binder_impl<Ret>{}, std::index_sequence_for<Args...>{}, func, args, std::forward_as_tuple(others...))))
            -> decltype(call_binder(binder_impl<Ret>{}, std::index_sequence_for<Args...>{}, func, args, std::forward_as_tuple(others...)))
        {
            return call_binder(binder_impl<Ret>{}, std::index_sequence_for<Args...>{}, func, args, std::forward_as_tuple(others...));
        };
    };
    template <typename Ret = Unforced, typename Func, typename... Args>
    [[nodiscard]] constexpr binder<Ret, Func, Args...> bind(Func&& func, Args&&... args)
        noexcept(noexcept(binder<Ret, Func, Args...>(std::forward<Func>(func), std::forward<Args>(args)...)))
    {
        return binder<Ret, Func, Args...>(std::forward<Func>(func), std::forward<Args>(args)...);
    };
}
struct sub_func
{
    int operator ()(int a, int b) const
    {
        std::cout << "sub" << std::endl;
        return a - b;
    };
};
int main()
{
    {
        auto sub = [](int a, int b) -> int
        {
            std::cout << "sub" << std::endl;
            return a - b;
        };
        /*sub_func sub;*/
        auto sub2 = std::bind(sub, std::placeholders::_2, std::placeholders::_1);
        const auto f = [](int a, int b, double c, char d, auto e) -> bool {
            std::cout << "f" << std::endl;
            int n = e(a, b);
            std::cout << "f2" << std::endl;
            return true;
        };
        double r = 4.1;
        auto b = std::bind(f, 1, std::placeholders::_3, std::placeholders::_1, std::placeholders::_2, std::placeholders::_4);
        auto c = std::bind(b, std::placeholders::_3, std::placeholders::_2, std::placeholders::_1, std::placeholders::_4);
        auto d = std::bind(c, std::placeholders::_2, std::placeholders::_1, std::ref(r), [sub2](int a, int b) { return sub2(a, b); });
        auto e = d(5, 3);
        
    }
    {
        /*auto sub = [](int a, int b) -> int
        {
            std::cout << "sub" << std::endl;
            return a - b;
        };*/
        sub_func sub;
        auto sub2 = my::bind(sub, my::place<2>, my::place<1>);
        const auto f = [](int a, int b, double c, char d, auto e) -> bool {
            std::cout << "f" << std::endl;
            int n = e(a, b);
            std::cout << "f2" << std::endl;
            return true;
        };
        double r = 4.1;
        auto b = my::bind(f, 1, my::place<3>, my::place<1>, my::place<2>, my::place<4>);
        auto c = my::bind(b, my::place<3>, my::place<2>, my::place<1>, my::place<4>);
        auto d = my::bind(c, my::place<2>, my::place<1>, std::ref(r), sub2);
        auto e = d(5, 3);
    }

    std::string line;
    std::getline(std::cin, line);
};
