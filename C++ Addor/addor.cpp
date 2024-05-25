template <typename T>
struct Addor
{
    static_assert(std::is_integral_v<T>);
    T data;
    constexpr Addor() = default;
    constexpr Addor(const Addor&) = default;
    constexpr Addor(Addor&&) = default;
    template <typename U>
    constexpr Addor& operator =(U u)&
    {
        static_assert(std::is_integral_v<U>);
        this->data = static_cast<T>(u);
        return *this;
    };
    template <typename U>
    constexpr Addor& operator +=(U u)&
    {
        static_assert(std::is_integral_v<U>);
        this->data = static_cast<T>(this->data + static_cast<T>(u));
        return *this;
    };
    template <typename U>
    constexpr Addor& operator -=(U u)&
    {
        static_assert(std::is_integral_v<U>);
        this->data = static_cast<T>(this->data - static_cast<T>(u));
        return *this;
    };
    template <typename U>
    constexpr Addor&& operator +(U u)&&
    {
        static_assert(std::is_integral_v<U>);
        this->data = static_cast<T>(this->data + static_cast<T>(u));
        return std::move(*this);
    };
    template <typename U>
    constexpr Addor&& operator -(U u)&&
    {
        static_assert(std::is_integral_v<U>);
        this->data = static_cast<T>(this->data - static_cast<T>(u));
        return std::move(*this);
    };
    constexpr operator T() { return this->data; };
};
template <typename T>
struct Addor<T*>
{
    static_assert(std::is_integral_v<T>);
    T* data;
    constexpr Addor() = default;
    template <typename U>
    constexpr Addor&& operator <<(U& u)&&
    {
        static_assert(std::is_integral_v<U>);
        this->data = reinterpret_cast<T*>(&u);
        return std::move(*this);
    };
    template <typename U>
    constexpr Addor&& operator =(U u)&&
    {
        static_assert(std::is_integral_v<U>);
        *this->data = static_cast<T>(u);
        return std::move(*this);
    };
    template <typename U>
    constexpr Addor&& operator +=(U u)&&
    {
        static_assert(std::is_integral_v<U>);
        *this->data = static_cast<T>(*this->data + static_cast<T>(u));
        return std::move(*this);
    };
    template <typename U>
    constexpr Addor&& operator -=(U u)&&
    {
        static_assert(std::is_integral_v<U>);
        *this->data = static_cast<T>(*this->data - static_cast<T>(u));
        return std::move(*this);
    };
};