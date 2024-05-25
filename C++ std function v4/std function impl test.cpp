    {
        auto sub = [](int a, int b) -> int { return a - b; };
        auto sub2 = std::bind(sub, std::placeholders::_2, std::placeholders::_1);
        const auto f = [](int a, int b, double c, char d, auto e) -> bool {
            int n = e(a, b);
            return true;
        };
        auto b = std::bind(f, 1, std::placeholders::_3, std::placeholders::_1, std::placeholders::_2, std::placeholders::_4);
        std::bind(b, std::placeholders::_3, std::placeholders::_2, std::placeholders::_1, std::placeholders::_4)(3, 5, 4.1, sub2);
    }
    {
        auto sub = [](int a, int b) -> int { return a - b; };
        auto sub2 = my::bind(sub, my::place<2>, my::place<1>);
        const auto f = [](int a, int b, double c, char d, auto e) -> bool {
            int n = e(a, b);
            return true;
        };
        auto b = my::bind(f, 1, my::place<3>, my::place<1>, my::place<2>, my::place<4>);
        my::bind(b, my::place<3>, my::place<2>, my::place<1>, my::place<4>)(3, 5, 4.1, sub2);
    }