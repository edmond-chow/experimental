template <typename T>
struct function;
template <typename Ret, typename... Args>
struct function<Ret(Args...)>
{
private:
    struct callable
    {
    public:
        virtual ~callable() noexcept = default;
        virtual Ret call(Args...) const = 0;
    };
    template <typename object>
    struct callable_impl : public callable
    {
    public:
        callable_impl(object Object) : Object(std::move(Object)) {};
        Ret call(Args... args) const { return std::invoke(Object, std::forward<Args>(args)...); };
        object Object;
    };
    std::shared_ptr<callable> Callable;
public:
    template <typename object>
    function(object Object) : Callable(std::make_unique<callable_impl<object>>(std::move(Object))) {};
    function(const function& function) : Callable(function.Callable) {};
    function(function&& function) : Callable(function.Callable) { function.Callable = 0; };
    Ret operator ()(Args... args) const { return Callable->call(std::forward<Args>(args)...); };
    using result_type = Ret;
};