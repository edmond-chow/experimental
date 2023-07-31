#include <list>
template <class T, class Alloc>
void sort_List(std::list<T, Alloc>& list)
{
    std::list<T, Alloc> tmp;
    list.swap(tmp);
    while (!tmp.empty())
    {
        std::list<T, Alloc> carry;
        carry.splice(carry.begin(), tmp, tmp.begin());
        list.merge(carry);
    }
};
int main()
{
    std::list<unsigned int> MyList{ 15, 90, 45, 96, 72, 70, 73, 31, 55, 89 };
    sort_List(MyList);
};