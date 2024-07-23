#if (__cplusplus >= 201402L) || (defined(_MSVC_LANG) && (_MSVC_LANG >= 201402L) && (_MSC_VER >= 1800))
#pragma once
#ifndef __PLACEHOLDER
#define __PLACEHOLDER
#pragma push_macro("INLINE_VAR")
#pragma push_macro("CONSTEXPR20")
#if (__cplusplus >= 201703L) || (defined(_MSVC_LANG) && (_MSVC_LANG >= 201703L) && (_MSC_VER >= 1800))
#define INLINE_VAR inline
#else
#define INLINE_VAR
#endif
#if (__cplusplus >= 202002L) || (defined(_MSVC_LANG) && (_MSVC_LANG >= 202002L) && (_MSC_VER >= 1800))
#define CONSTEXPR20 constexpr
#else
#define CONSTEXPR20
#endif
namespace std
{
    template <std::size_t n>
    struct impl_placeholder
    {
    public:
        constexpr impl_placeholder() noexcept = default;
        CONSTEXPR20 ~impl_placeholder() noexcept = default;
    };
    template <std::size_t n>
    INLINE_VAR constexpr impl_placeholder<n> placeholder;
    template<std::size_t n>
    struct is_placeholder<impl_placeholder<n>> : std::integral_constant<std::size_t, n> {};
}
#pragma pop_macro("CONSTEXPR20")
#pragma pop_macro("INLINE_VAR")
#endif
#endif
