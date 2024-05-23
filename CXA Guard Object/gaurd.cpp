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