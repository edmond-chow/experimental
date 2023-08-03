﻿#pragma once
#ifndef CMPLX_UNIT_TEST
#define CMPLX_UNIT_TEST
#include <array>
#include <string>
#include <stdexcept>
#include <functional>
#include <limits>
template <typename string_type>
std::int64_t stoi64_t(const string_type& str)
{
	using ul = decltype(std::stoul(string_type()));
	using ull = decltype(std::stoull(string_type()));
	if constexpr (sizeof(std::int64_t) == sizeof(ul)) { return static_cast<std::int64_t>(std::stol(str)); }
	if constexpr (sizeof(std::int64_t) >= sizeof(ull)) { return static_cast<std::int64_t>(std::stoll(str)); }
	else
	{
		ull ret = std::stoll(str);
		if (ret > static_cast<ull>(std::numeric_limits<std::int64_t>::max())) { throw std::out_of_range("stoull argument out of range"); }
		return static_cast<std::int64_t>(ret);
	}
};
template <typename T>
inline std::wstring to_wstring(T t)
{
	if constexpr (requires (T t) { std::to_wstring(t); }) { return std::to_wstring(t); }
	else { return to_wstring(T::CType_String(t)); }
};
template <>
inline std::wstring to_wstring<bool>(bool t) { return t ? L"true" : L"false"; };
template <>
inline std::wstring to_wstring<std::wstring>(std::wstring t) { return t; };
namespace ComplexTestingConsole
{
	class Base final
	{
	private:
		constexpr Base() noexcept = delete;
		constexpr ~Base() noexcept = delete;
		///
		/// Base
		///
	public:
		static std::wstring GetTitle();
		static std::wstring GetStartupLine();
		static bool IsSwitchTo(const std::wstring& Str);
		///
		/// Main Thread
		///
		static void Main();
		///
		/// Console Line Materials
		///
		static std::wstring Exception(const std::exception& ex);
		static std::wstring Exception();
		static std::wstring Selection(const std::wstring& str);
		static std::wstring Selection();
		static std::wstring Input(const std::wstring& str);
		static std::wstring Input();
		static std::wstring Output(const std::wstring& main, const std::wstring& str);
		static std::wstring Output(const std::wstring& str);
		static std::wstring Output();
		static std::wstring Comment(const std::wstring& head, const std::wstring& str);
		static std::wstring Comment(const std::wstring& str);
		static std::wstring Comment();
		static void Startup(const std::wstring& title);
	};
	template <std::size_t I, std::size_t S>
	std::wstring get_angle_name(std::integral_constant<std::size_t, I>, const std::array<const wchar_t*, S>& Angle)
	{
		return I < S ? std::get<I>(Angle) : L"Angle" + to_wstring(I);
	};
	template <typename... Args>
	std::wstring get_output_prepend_impl(const std::wstring& prepend, const std::wstring& midend, const std::wstring& append, std::int64_t arg)
	{
		return prepend + to_wstring(arg) + append;
	};
	template <typename... Args>
	std::wstring get_output_prepend_impl(const std::wstring& prepend, const std::wstring& midend, const std::wstring& append, std::int64_t arg, Args... args)
	{
		return get_output_prepend_impl(prepend + to_wstring(arg) + midend, midend, append, args...);
	};
	template <typename... Args>
	std::wstring get_output_prepend(const std::wstring& str, Args... args)
	{
		return get_output_prepend_impl(str + L"(", L", ", L") = ", args...);
	};
	template <typename T, std::size_t I = 0, std::size_t A, std::size_t S>
	void power_get_impl(std::array<T, A>& Data, const std::array<const wchar_t*, S>& Angle)
	{
		if constexpr (I < A)
		{
			const wchar_t* Assign = L" = ";
			if constexpr (std::is_same_v<T, std::int64_t>)
			{
				std::get<I>(Data) = stoi64_t(Base::Input(get_angle_name(std::integral_constant<std::size_t, I>{}, Angle) + Assign));
			}
			else if constexpr (std::is_same_v<T, std::pair<std::int64_t, std::int64_t>>)
			{
				std::int64_t Min = stoi64_t(Base::Input(get_angle_name(std::integral_constant<std::size_t, I>{}, Angle) + L"Min" + Assign));
				std::int64_t Max = stoi64_t(Base::Input(get_angle_name(std::integral_constant<std::size_t, I>{}, Angle) + L"Max" + Assign));
				if (Min > Max) { std::swap(Min, Max); }
				std::get<I>(Data) = std::make_pair<std::int64_t, std::int64_t>(std::move(Min), std::move(Max));
			}
			if constexpr (I < A)
			{
				power_get_impl<T, I + 1, A, S>(Data, Angle);
			}
		}
	};
	template <typename T, std::size_t A>
	void power_get(std::array<T, A>& Data)
	{
		std::array<const wchar_t*, 4> Angle{ L"Theta", L"Phi", L"Tau", L"Omega" };
		power_get_impl(Data, Angle);
	};
	template <typename F, typename N, std::size_t A, std::size_t... I>
	void power_result_impl(F f, const N& Union, const N& Value, const std::array<std::int64_t, A>& Data, std::integer_sequence<std::size_t, I...>)
	{
		Base::Output(to_wstring(std::invoke(f, Union, Value, std::get<I>(Data)...)));
	};
	template <typename F, typename N, std::size_t A, std::size_t... I>
	void power_result_impl(F f, const std::wstring& str, const N& Union, const N& Value, const std::array<std::int64_t, A>& Temp, std::integer_sequence<std::size_t, I...>)
	{
		Base::Output(
			get_output_prepend(str, std::get<I>(Temp)...),
			to_wstring(std::invoke(f, Union, Value, std::get<I>(Temp)...))
		);
	};
	template <typename F, typename N, std::size_t A, std::size_t I = 0>
	void power_result_impl(F f, const std::wstring& str, const N& Union, const N& Value, const std::array<std::pair<std::int64_t, std::int64_t>, A>& Data, std::array<std::int64_t, A>& Temp)
	{
		if constexpr (I < A)
		{
			while (std::get<I>(Temp) <= std::get<I>(Data).second)
			{
				power_result_impl<F, N, A, I + 1>(f, str, Union, Value, Data, Temp);
				std::get<I>(Temp) = std::get<I>(Temp) + 1;
			}
			std::get<I>(Temp) = std::get<I>(Data).first;
		}
		else if constexpr (I == A)
		{
			power_result_impl(f, str, Union, Value, Temp, std::make_index_sequence<A>{});
		}
	};
	template <std::size_t A, std::size_t I = 0>
	void power_temp_init(const std::array<std::pair<std::int64_t, std::int64_t>, A>& Data, std::array<std::int64_t, A>& Temp)
	{
		if constexpr (I < A)
		{
			std::get<I>(Temp) = std::get<I>(Data).first;
			power_temp_init<A, I + 1>(Data, Temp);
		}
	};
	template <typename T, typename F, typename N, std::size_t A>
	void power_result(F f, const std::wstring& str, const N& Union, const N& Value, const std::array<T, A>& Data)
	{
		if constexpr (std::is_same_v<T, std::int64_t>)
		{
			power_result_impl(f, Union, Value, Data, std::make_index_sequence<A>{});
		}
		else if constexpr (std::is_same_v<T, std::pair<std::int64_t, std::int64_t>>)
		{
			std::array<std::int64_t, A> Temp{};
			power_temp_init(Data, Temp);
			power_result_impl(f, str, Union, Value, Data, Temp);
		}
	};
}
#define CMPLX_UNIT_TEST_INTERFACE
#endif
