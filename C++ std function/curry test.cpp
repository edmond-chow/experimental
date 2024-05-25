    std::function<int(int, double)> t = [](int i, double d)
    {
        std::cout << i << std::endl << d << std::endl;
        return 1234;
    };
    auto t3 = [](int i, double d, int i2, double d2, int i3, double d3)
    {
        std::cout << i << std::endl << d << std::endl;
        std::cout << i2 << std::endl << d2 << std::endl;
        std::cout << i3 << std::endl << d3 << std::endl;
        return 1234567;
    };

    auto cc = curry
    (t3, std::placeholder<2>, std::placeholder<1>, std::placeholder<3>, std::placeholder<4>, std::placeholder<5>, std::placeholder<6>)
    (1.5, 6, std::placeholder<1>, std::placeholder<2>, std::placeholder<3>, std::placeholder<4>)
    (3, std::placeholder<1>, 78, 2.75)(5.69);
     //auto cc1 = cc(6);
    
    auto fffff = curry(t)(6)(1.5);