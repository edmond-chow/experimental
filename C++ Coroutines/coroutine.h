#if (__cplusplus >= 202002L) || (defined(_MSVC_LANG) && (_MSVC_LANG >= 202002L) && (_MSC_VER >= 1800))
#pragma once
#ifndef COROUTINE
#define COROUTINE
#include <coroutine>
template <typename T>
struct task
{
public:
    static_assert(!std::is_reference_v<T>, "task<T> requires T to be a value type or a void type.");
    struct promise_type
    {
    private:
        std::remove_const_t<T> instance;
    public:
        friend struct task;
        task get_return_object() const noexcept { return task(std::coroutine_handle<promise_type>::from_promise(*const_cast<promise_type*>(this))); };
        void unhandled_exception() const noexcept {};
        std::suspend_never initial_suspend() const noexcept { return std::suspend_never(); };
        std::suspend_always final_suspend() const noexcept { return std::suspend_always(); };
        std::suspend_always yield_value(const std::remove_const_t<T>& value) & noexcept requires !std::is_const_v<T>
        {
            instance = value;
            return std::suspend_always();
        };
        std::suspend_always yield_value(std::remove_const_t<T>&& value) & noexcept requires !std::is_const_v<T>
        {
            instance = value;
            return std::suspend_always();
        };
        void return_value(const std::remove_const_t<T>& value) & noexcept { instance = value; };
        void return_value(std::remove_const_t<T>&& value) & noexcept { instance = value; };
    };
private:
    std::coroutine_handle<promise_type> coroutine;
public:
    task() noexcept = default;
    task(const task&) noexcept = delete;
    task(task&& task) noexcept : coroutine(task.coroutine) { task.coroutine = nullptr; };
    explicit task(const std::coroutine_handle<promise_type>& coroutine) noexcept : coroutine(coroutine) {};
    task& operator =(const task&) & noexcept = delete;
    task& operator =(task&& task) & noexcept
    {
        coroutine = task.coroutine;
        task.coroutine = nullptr;
    };
    std::decay_t<T> get() const noexcept { return coroutine.promise().instance; };
    void resume() const noexcept { coroutine.resume(); };
    bool done() const noexcept { return coroutine.done(); };
    ~task() noexcept
    {
        if (coroutine) { coroutine.destroy(); }
    };
};
template <typename T> requires std::is_void_v<T>
struct task<T>
{
public:
    struct promise_type
    {
    private:
        std::size_t instance;
    public:
        friend struct task;
        task get_return_object() const noexcept { return task(std::coroutine_handle<promise_type>::from_promise(*const_cast<promise_type*>(this))); };
        void unhandled_exception() const noexcept {};
        std::suspend_never initial_suspend() const noexcept { return std::suspend_never(); };
        std::suspend_always final_suspend() const noexcept { return std::suspend_always(); };
        void return_void() & noexcept { instance = 0; };
    };
private:
    std::coroutine_handle<promise_type> coroutine;
public:
    task() noexcept = default;
    task(const task&) noexcept = delete;
    task(task&& task) noexcept : coroutine(task.coroutine) { task.coroutine = nullptr; };
    explicit task(const std::coroutine_handle<promise_type>& coroutine) noexcept : coroutine(coroutine) {};
    task& operator =(const task&) & noexcept = delete;
    task& operator =(task&& task) & noexcept
    {
        coroutine = task.coroutine;
        task.coroutine = nullptr;
    };
    void get() const noexcept { coroutine.promise().instance = 0; };
    void resume() const noexcept { coroutine.resume(); };
    bool done() const noexcept { return coroutine.done(); };
    ~task() noexcept
    {
        if (coroutine) { coroutine.destroy(); }
    };
};
#endif
#endif
