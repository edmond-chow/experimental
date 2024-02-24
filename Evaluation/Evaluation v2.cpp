#include <csetjmp>
#include <stdexcept>
#include <functional>
using operate_t = std::function<void()>;
using caught_t = std::function<void(const std::exception& ex)>;
enum ev_state : int
{
	before = -1,
	operate = 0,
	after = 1,
};
static const std::runtime_error unhandled{ "An unhandled exception has occurred." };
struct eval
{
private:
	static thread_local eval* last;
	static thread_local const std::exception* captured;
	eval* previous;
	const caught_t* handler;
	std::jmp_buf sp;
public:
	eval(const caught_t& handler)
		: previous{ last }, handler{ &handler }, sp{}
	{
		last = this;
	};
	std::jmp_buf& success()
	{
		last = this->previous;
		return this->sp;
	};
	std::jmp_buf& failure(const std::exception* ex_ptr)
	{
		last = this->previous;
		if (ex_ptr != nullptr) { captured = ex_ptr; }
		else if (captured == nullptr) { captured = &unhandled; }
		this->handler->operator()(*captured);
		captured = nullptr;
		return this->sp;
	};
	std::jmp_buf& get_sp()
	{
		return this->sp;
	};
	static eval* get_last()
	{
		return last;
	};
};
thread_local eval* eval::last{ nullptr };
thread_local const std::exception* eval::captured{ nullptr };
void evaluate(const operate_t& operate, const caught_t& caught) noexcept
{
	eval local{ caught };
	int jmp = setjmp(local.get_sp());
	if (jmp == ev_state::operate)
	{
		operate.operator()();
		eval::get_last()->success();
	}
	else if (jmp == ev_state::before)
	{
		eval::get_last()->failure(&unhandled);
	}
};
void throw_now(const std::exception& ex) noexcept
{
	if (eval::get_last() == nullptr) { std::terminate(); }
	std::longjmp(eval::get_last()->failure(&ex), ev_state::after);
};
void rethrow_current() noexcept
{
	if (eval::get_last() == nullptr) { std::terminate(); }
	std::longjmp(eval::get_last()->failure(nullptr), ev_state::after);
};
void abort_unwind() noexcept
{
	if (eval::get_last() != nullptr) { std::longjmp(eval::get_last()->get_sp(), ev_state::before); }
};
#include <iostream>
struct fn_list
{
private:
	static const std::size_t count = 32;
	static std::size_t slot;
	static fn_list* last;
	fn_list* previous;
	void (*func[count])(void*);
	void* arg[count];
	fn_list() = default;
	static fn_list* get_default()
	{
		static fn_list list{};
		return &list;
	};
public:
	static int push(void (*func)(void*), void* arg)
	{
		if (empty()) { last = get_default(); }
		if (slot == count)
		{
			fn_list* node = new (std::nothrow) fn_list{};
			if (node == nullptr) { return -1; }
			node->previous = last;
			last = node;
			slot = 0;
		}
		std::wcout << L"push(" << (uintptr_t)func << L", " << (uintptr_t)arg << L") [" << slot << L"]" << std::endl;
		last->func[slot] = func;
		last->arg[slot] = arg;
		++slot;
		return 0;
	};
	static int pop()
	{
		if (empty()) { return -1; }
		--slot;
		void (*fn_ptr)(void*) = last->func[slot];
		if (fn_ptr != nullptr) { (*fn_ptr)(last->arg[slot]); }
		std::wcout << L"pop(" << (uintptr_t)fn_ptr << L", " << (uintptr_t)last->arg[slot] << L") [" << slot << L"]" << std::endl;
		if (!empty() && slot == 0)
		{
			slot = count;
			fn_list* node = last;
			last = node->previous;
			delete node;
		}
		return 0;
	};
	static bool empty()
	{
		return last == nullptr || (last == get_default() && slot == 0);
	};
};
std::size_t fn_list::slot{ 0 };
fn_list* fn_list::last{ nullptr };
extern "C" int __cxa_atexit(void (*func)(void*), void* arg, void* dso_handle)
{
	return fn_list::push(func, arg);
};
extern "C" {
	extern char __global_base;
	extern char __data_end;
}
extern "C" void* global_base()
{
	return &__global_base;
};
extern "C" void* data_end()
{
	return &__data_end;
};
void invoke_atexit()
{
	while (!fn_list::empty())
	{
		fn_list::pop();
	}
};
/*
static constexpr const int INIT_IS_DONE = 0;
static constexpr const int INIT_IS_PENDING = 1;
static constexpr uint8_t UNSET = 0;
static constexpr uint8_t COMPLETE_BIT = (1 << 0);
static constexpr uint8_t PENDING_BIT = (1 << 1);
static constexpr uint8_t WAITING_BIT = (1 << 2);
struct guard_object
{
public:
	guard_object() = delete;
	guard_object(guard_object const&) = delete;
	guard_object& operator =(guard_object const&) = delete;
	explicit guard_object(uint8_t* raw_guard_object) : guard_object_address{ raw_guard_object } {};
	int acquire()
	{
		if (guard_object_address[0] != UNSET || guard_object_address[1] == COMPLETE_BIT) { return INIT_IS_DONE; }
		if (guard_object_address[1] & PENDING_BIT) { abort(); }
		guard_object_address[1] = PENDING_BIT;
		return INIT_IS_PENDING;
	};
	void release()
	{
		guard_object_address[0] = COMPLETE_BIT;
		guard_object_address[1] = COMPLETE_BIT;
	};
	void abort()
	{
		guard_object_address[1] = UNSET;
	};
	void free()
	{
		guard_object_address[0] = UNSET;
		guard_object_address[1] = UNSET;
	};
private:
	uint8_t* const guard_object_address;
};
void free_guard_object(void* raw_guard_object)
{
	guard_object guard{ reinterpret_cast<uint8_t*>(raw_guard_object) };
	guard.free();
};
extern "C" int __cxa_guard_acquire(uint8_t* raw_guard_object)
{
	std::wcout << L"__cxa_guard_acquire" << std::endl;
	fn_list::push(&free_guard_object, raw_guard_object);
	guard_object guard{ raw_guard_object };
	return guard.acquire();
};
extern "C" void __cxa_guard_release(uint8_t* raw_guard_object)
{
	guard_object guard{ raw_guard_object };
	guard.release();
};
extern "C" void __cxa_guard_abort(uint8_t* raw_guard_object)
{
	guard_object guard{ raw_guard_object };
	guard.abort();
};
*/