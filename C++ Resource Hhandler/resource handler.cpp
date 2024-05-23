#include <memory_resource>
struct resource_handler
{
private:
    std::pmr::memory_resource* pushed_resource;
    std::pmr::monotonic_buffer_resource resource;
    std::byte buffer[4096];
public:
    resource_handler() : pushed_resource{ std::pmr::get_default_resource() }, resource{ buffer, std::extent_v<decltype(buffer)> }, buffer{}
    {
        std::pmr::set_default_resource(&resource);
    };
    ~resource_handler()
    {
        std::pmr::set_default_resource(pushed_resource);
    };
};