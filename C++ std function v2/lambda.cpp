    using Func = decltype([](int i, double d, int i2, double d2, int i3, double d3)
        {
            std::cout << i << std::endl << d << std::endl;
            std::cout << i2 << std::endl << d2 << std::endl;
            std::cout << i3 << std::endl << d3 << std::endl;
            return 1234567;
        });
    Func func1;
    Func func2(func1); // c++17
    Func func3(std::move(func1)); // c++17
    func1 = func2;
    func1 = std::move(func2);