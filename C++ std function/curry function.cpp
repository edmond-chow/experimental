template <typename Callable, typename... Params>
auto curry(Callable callable, Params... params)
{
    if constexpr (requires { callable(params...); }) { return callable(params...); }
    else
    {
        return[callable, params...](auto... others) -> auto
        {
            //if constexpr (requires { callable(params..., others...); }) { return callable(params..., others...); }
            /*else*/ { return curry(std::bind(callable, params...), others...); }
        };
    }
};