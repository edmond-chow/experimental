constexpr int f() {
    int* p = new int(42);
    int v = *p;
    delete p;
    return v;
}
static_assert(f() == 42);
int main()
{
    return f();
}