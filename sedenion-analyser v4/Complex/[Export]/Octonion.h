﻿#if (__cplusplus >= 201103L) || (defined(_MSVC_LANG) && (_MSVC_LANG >= 201103L) && (_MSC_VER >= 1800))
#pragma once
#ifndef OCTON
#define OCTON
#include <string>
#include <stdexcept>
#pragma pack(push)
#pragma push_macro("CALL")
#pragma push_macro("OCTON_INTERFACE")
#pragma push_macro("OCTON_FUNC_CALL")
#pragma push_macro("OCTON_FUNC_INSTANCE_CALL")
#define CALL(c)
#define OCTON_INTERFACE
#define OCTON_FUNC_CALL
#define OCTON_FUNC_INSTANCE_CALL
namespace Octon
{
	namespace BaseType
	{
		enum struct index : std::int64_t
		{
			e1 = 1,
			e2 = 2,
			e3 = 3,
			e4 = 4,
			e5 = 5,
			e6 = 6,
			e7 = 7,
		};
		struct OCTON_INTERFACE Vector7D
		{
		public:
			///
			/// constants
			///
			static const double pi;
			static const double e;
			static const Vector7D e1;
			static const Vector7D e2;
			static const Vector7D e3;
			static const Vector7D e4;
			static const Vector7D e5;
			static const Vector7D e6;
			static const Vector7D e7;
		private:
			///
			/// basis
			///
			double x1;
			double x2;
			double x3;
			double x4;
			double x5;
			double x6;
			double x7;
		public:
			explicit OCTON_FUNC_INSTANCE_CALL Vector7D() noexcept;
			explicit OCTON_FUNC_INSTANCE_CALL Vector7D(double x1, double x2, double x3, double x4, double x5, double x6, double x7) noexcept;
			OCTON_FUNC_INSTANCE_CALL Vector7D(const Vector7D& Value) noexcept;
			///
			/// operators
			///
			Vector7D OCTON_FUNC_INSTANCE_CALL operator ()() const noexcept;
			double& OCTON_FUNC_INSTANCE_CALL operator [](index i) &;
			double& OCTON_FUNC_INSTANCE_CALL operator [](std::size_t i) & noexcept;
			const double& OCTON_FUNC_INSTANCE_CALL operator [](index i) const&;
			const double& OCTON_FUNC_INSTANCE_CALL operator [](std::size_t i) const& noexcept;
			Vector7D& OCTON_FUNC_INSTANCE_CALL operator =(const Vector7D& Value) & noexcept;
			Vector7D& OCTON_FUNC_INSTANCE_CALL operator +=(const Vector7D& Value) & noexcept;
			Vector7D& OCTON_FUNC_INSTANCE_CALL operator +=(const std::initializer_list<Vector7D>& Value) & noexcept;
			Vector7D& OCTON_FUNC_INSTANCE_CALL operator -=(const Vector7D& Value) & noexcept;
			Vector7D& OCTON_FUNC_INSTANCE_CALL operator -=(const std::initializer_list<Vector7D>& Value) & noexcept;
			Vector7D& OCTON_FUNC_INSTANCE_CALL operator *=(double Value) & noexcept;
			Vector7D& OCTON_FUNC_INSTANCE_CALL operator *=(const std::initializer_list<double>& Value) & noexcept;
			Vector7D& OCTON_FUNC_INSTANCE_CALL operator /=(double Value) & noexcept;
			Vector7D& OCTON_FUNC_INSTANCE_CALL operator /=(const std::initializer_list<double>& Value) & noexcept;
			///
			/// fundamentals
			///
			static double OCTON_FUNC_CALL abs(const Vector7D& Value);
			static Vector7D OCTON_FUNC_CALL sgn(const Vector7D& Value);
			static double OCTON_FUNC_CALL dot(const Vector7D& Union, const Vector7D& Value) noexcept;
			static Vector7D OCTON_FUNC_CALL cross(const Vector7D& Union, const Vector7D& Value) noexcept;
			///
			/// conventions
			///
			static std::wstring OCTON_FUNC_CALL GetString(const Vector7D& Value);
			static Vector7D OCTON_FUNC_CALL GetInstance(const std::wstring& Value);
		};
		///
		/// operators
		///
		bool OCTON_INTERFACE OCTON_FUNC_CALL operator ==(const Vector7D& Union, const Vector7D& Value) noexcept;
		bool OCTON_INTERFACE OCTON_FUNC_CALL operator !=(const Vector7D& Union, const Vector7D& Value) noexcept;
		Vector7D OCTON_INTERFACE OCTON_FUNC_CALL operator +(const Vector7D& Value) noexcept;
		Vector7D OCTON_INTERFACE OCTON_FUNC_CALL operator -(const Vector7D& Value) noexcept;
		Vector7D OCTON_INTERFACE OCTON_FUNC_CALL operator +(const Vector7D& Union, const Vector7D& Value) noexcept;
		Vector7D OCTON_INTERFACE OCTON_FUNC_CALL operator -(const Vector7D& Union, const Vector7D& Value) noexcept;
		Vector7D OCTON_INTERFACE OCTON_FUNC_CALL operator *(double Union, const Vector7D& Value) noexcept;
		Vector7D OCTON_INTERFACE OCTON_FUNC_CALL operator *(const Vector7D& Union, double Value) noexcept;
		Vector7D OCTON_INTERFACE OCTON_FUNC_CALL operator /(const Vector7D& Union, double Value) noexcept;
	}
	namespace MainType
	{
		enum struct index : std::int64_t
		{
			s = 0,
			i = 1,
			j = 2,
			k = 3,
			l = 4,
			il = 5,
			jl = 6,
			kl = 7,
		};
		struct OCTON_INTERFACE Octonion
		{
		public:
			///
			/// constants
			///
			static const double pi;
			static const double e;
			static const Octonion i;
			static const Octonion j;
			static const Octonion k;
			static const Octonion l;
			static const Octonion il;
			static const Octonion jl;
			static const Octonion kl;
		private:
			///
			/// basis
			///
			double real;
			BaseType::Vector7D imaginary;
		public:
			explicit OCTON_FUNC_INSTANCE_CALL Octonion() noexcept;
			explicit OCTON_FUNC_INSTANCE_CALL Octonion(double s, const BaseType::Vector7D& v) noexcept;
			explicit OCTON_FUNC_INSTANCE_CALL Octonion(double s, double i, double j, double k, double l, double il, double jl, double kl) noexcept;
			OCTON_FUNC_INSTANCE_CALL Octonion(double Value) noexcept;
			OCTON_FUNC_INSTANCE_CALL Octonion(const BaseType::Vector7D& Value) noexcept;
			OCTON_FUNC_INSTANCE_CALL Octonion(const Octonion& Value) noexcept;
			static double OCTON_FUNC_CALL Scalar(const Octonion& Value) noexcept;
			static BaseType::Vector7D OCTON_FUNC_CALL Vector(const Octonion& Value) noexcept;
			///
			/// operators
			///
			Octonion OCTON_FUNC_INSTANCE_CALL operator ()() const noexcept;
			double& OCTON_FUNC_INSTANCE_CALL operator [](index i) &;
			double& OCTON_FUNC_INSTANCE_CALL operator [](std::size_t i) & noexcept;
			const double& OCTON_FUNC_INSTANCE_CALL operator [](index i) const&;
			const double& OCTON_FUNC_INSTANCE_CALL operator [](std::size_t i) const& noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator ++() & noexcept;
			Octonion OCTON_FUNC_INSTANCE_CALL operator ++(int) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator --() & noexcept;
			Octonion OCTON_FUNC_INSTANCE_CALL operator --(int) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator =(const Octonion& Value) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator +=(const Octonion& Value) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator +=(const std::initializer_list<Octonion>& Value) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator -=(const Octonion& Value) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator -=(const std::initializer_list<Octonion>& Value) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator *=(const Octonion& Value) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator *=(const std::initializer_list<Octonion>& Value) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator /= (const Octonion& Value) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator /=(const std::initializer_list<Octonion>& Value) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator ^=(std::int64_t Exponent) & noexcept;
			Octonion& OCTON_FUNC_INSTANCE_CALL operator ^=(const std::initializer_list<std::int64_t>& Exponent) & noexcept;
			///
			/// fundamentals
			///
			static double OCTON_FUNC_CALL abs(const Octonion& Value);
			static double OCTON_FUNC_CALL arg(const Octonion& Value);
			static double OCTON_FUNC_CALL arg(const Octonion& Value, std::int64_t Theta);
			static Octonion OCTON_FUNC_CALL conjg(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL sgn(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL inverse(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL exp(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL ln(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL ln(const Octonion& Value, std::int64_t Theta);
			///
			/// multiples
			///
			static double OCTON_FUNC_CALL dot(const Octonion& Union, const Octonion& Value) noexcept;
			static BaseType::Vector7D OCTON_FUNC_CALL outer(const Octonion& Union, const Octonion& Value) noexcept;
			static Octonion OCTON_FUNC_CALL even(const Octonion& Union, const Octonion& Value) noexcept;
			static BaseType::Vector7D OCTON_FUNC_CALL cross(const Octonion& Union, const Octonion& Value) noexcept;
			///
			/// exponentials
			///
			static Octonion OCTON_FUNC_CALL power(const Octonion& Base, const Octonion& Exponent);
			static Octonion OCTON_FUNC_CALL power(const Octonion& Base, const Octonion& Exponent, std::int64_t Theta, std::int64_t Phi, std::int64_t Tau);
			static Octonion OCTON_FUNC_CALL power(const Octonion& Base, double Exponent);
			static Octonion OCTON_FUNC_CALL power(const Octonion& Base, double Exponent, std::int64_t Theta);
			static Octonion OCTON_FUNC_CALL root(const Octonion& Base, const Octonion& Exponent);
			static Octonion OCTON_FUNC_CALL root(const Octonion& Base, const Octonion& Exponent, std::int64_t Theta, std::int64_t Phi, std::int64_t Tau);
			static Octonion OCTON_FUNC_CALL root(const Octonion& Base, double Exponent);
			static Octonion OCTON_FUNC_CALL root(const Octonion& Base, double Exponent, std::int64_t Theta);
			static Octonion OCTON_FUNC_CALL log(const Octonion& Base, const Octonion& Number);
			static Octonion OCTON_FUNC_CALL log(const Octonion& Base, const Octonion& Number, std::int64_t Theta, std::int64_t Phi, std::int64_t Tau, std::int64_t Omega);
			///
			/// trigonometrics
			///
			static Octonion OCTON_FUNC_CALL sin(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arcsin(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arcsin(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL sinh(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arcsinh(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arcsinh(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL cos(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccos(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccos(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL cosh(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccosh(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccosh(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL tan(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arctan(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arctan(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL tanh(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arctanh(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arctanh(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL csc(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccsc(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccsc(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL csch(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccsch(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccsch(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL sec(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arcsec(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arcsec(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL sech(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arcsech(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arcsech(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL cot(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccot(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccot(const Octonion& Value, bool Sign, std::int64_t Period);
			static Octonion OCTON_FUNC_CALL coth(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccoth(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL arccoth(const Octonion& Value, bool Sign, std::int64_t Period);
			///
			/// conventions
			///
			static std::wstring OCTON_FUNC_CALL GetString(const Octonion& Value);
			static Octonion OCTON_FUNC_CALL GetInstance(const std::wstring& Value);
		};
		///
		/// operators
		///
		bool OCTON_INTERFACE OCTON_FUNC_CALL operator ==(const Octonion& Union, const Octonion& Value) noexcept;
		bool OCTON_INTERFACE OCTON_FUNC_CALL operator !=(const Octonion& Union, const Octonion& Value) noexcept;
		Octonion OCTON_INTERFACE OCTON_FUNC_CALL operator +(const Octonion& Value) noexcept;
		Octonion OCTON_INTERFACE OCTON_FUNC_CALL operator -(const Octonion& Value) noexcept;
		Octonion OCTON_INTERFACE OCTON_FUNC_CALL operator ~(const Octonion& Value) noexcept;
		Octonion OCTON_INTERFACE OCTON_FUNC_CALL operator +(const Octonion& Union, const Octonion& Value) noexcept;
		Octonion OCTON_INTERFACE OCTON_FUNC_CALL operator -(const Octonion& Union, const Octonion& Value) noexcept;
		Octonion OCTON_INTERFACE OCTON_FUNC_CALL operator *(const Octonion& Union, const Octonion& Value) noexcept;
		Octonion OCTON_INTERFACE OCTON_FUNC_CALL operator /(const Octonion& Union, const Octonion& Value) noexcept;
		Octonion OCTON_INTERFACE OCTON_FUNC_CALL operator ^(const Octonion& Base, std::int64_t Exponent) noexcept;
	}
}
#pragma pack(pop)
#endif
#endif
