﻿/*
 *   Copyright 2022 Edmond Chow
 *
 *   Licensed under the Apache License, Version 2.0 (the "License");
 *   you may not use this file except in compliance with the License.
 *   You may obtain a copy of the License at
 *
 *       http://www.apache.org/licenses/LICENSE-2.0
 *
 *   Unless required by applicable law or agreed to in writing, software
 *   distributed under the License is distributed on an "AS IS" BASIS,
 *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *   See the License for the specific language governing permissions and
 *   limitations under the License.
 */
#include <cstddef>
#include <cstdint>
#include <string>
#include "Module.h"
#include "Cayley Dickson Algebra.h"
#pragma pack(push)
#pragma push_macro("I")
#pragma push_macro("Gbl")
#pragma push_macro("Ths")
#pragma pack(8)
#if defined(_MSVC_LANG)
#define I __declspec(dllexport)
#define Gbl __stdcall
#define Ths __thiscall
#else
#define I
#define Gbl
#define Ths
#endif
namespace Num
{
	struct I Vec1D
	{
		///
		/// constants
		///
	public:
		static const Vec1D Zero;
		static const Vec1D e1;
		///
		/// basis
		///
	private:
		double x1;
	public:
		explicit Ths Vec1D();
		explicit Ths Vec1D(double e1);
		///
		/// operators
		///
	public:
		Vec1D Ths operator ()() const;
		double& Ths operator [](std::size_t i) &;
		const double& Ths operator [](std::size_t i) const&;
		friend bool I Gbl operator ==(const Vec1D& U, const Vec1D& V);
		friend bool I Gbl operator !=(const Vec1D& U, const Vec1D& V);
		friend Vec1D I Gbl operator +(const Vec1D& V);
		friend Vec1D I Gbl operator -(const Vec1D& V);
		friend Vec1D I Gbl operator +(const Vec1D& U, const Vec1D& V);
		friend Vec1D I Gbl operator -(const Vec1D& U, const Vec1D& V);
		friend Vec1D I Gbl operator *(const Vec1D& U, double V);
		friend Vec1D I Gbl operator *(double U, const Vec1D& V);
		friend Vec1D I Gbl operator /(const Vec1D& U, double V);
		Vec1D& Ths operator +=(const Vec1D& O) &;
		Vec1D& Ths operator +=(const std::initializer_list<Vec1D>& O) &;
		Vec1D& Ths operator -=(const Vec1D& O) &;
		Vec1D& Ths operator -=(const std::initializer_list<Vec1D>& O) &;
		Vec1D& Ths operator *=(double O) &;
		Vec1D& Ths operator *=(const std::initializer_list<double>& O) &;
		Vec1D& Ths operator /=(double O) &;
		Vec1D& Ths operator /=(const std::initializer_list<double>& O) &;
		///
		/// multiples
		///
	public:
		static double Gbl Dot(const Vec1D& U, const Vec1D& V);
		static Vec1D Gbl Cross(const Vec1D& U, const Vec1D& V);
		///
		/// fundamentals
		///
	public:
		static double Gbl Abs(const Vec1D& V);
		static Vec1D Gbl Sgn(const Vec1D& V);
		///
		/// conventions
		///
	public:
		static String Gbl Str(const Vec1D& V);
		static Vec1D Gbl Val(const String& V);
		///
		/// casing
		///
	public:
		Number Num() const&
		{
			return Number{ 0, x1 };
		};
		static Vec1D Val(const Number& N)
		{
			return Vec1D{ N[1] };
		};
	};
	/* struct Vec1D */
	///
	/// constants
	///
	const Vec1D Vec1D::Zero = Vec1D{ 0 };
	const Vec1D Vec1D::e1 = Vec1D{ 1 };
	///
	/// basis
	///
	Ths Vec1D::Vec1D()
		: x1{ 0 }
	{};
	Ths Vec1D::Vec1D(double e1)
		: x1{ e1 }
	{};
	///
	/// operators
	///
	Vec1D Ths Vec1D::operator ()() const
	{
		return *this;
	};
	double& Ths Vec1D::operator [](std::size_t i) &
	{
		switch (i)
		{
		case 1:
			return this->x1;
		default:
			throw std::out_of_range{ "The index is out of range." };
		}
	};
	const double& Ths Vec1D::operator [](std::size_t i) const&
	{
		switch (i)
		{
		case 1:
			return this->x1;
		default:
			throw std::out_of_range{ "The index is out of range." };
		}
	};
	bool I Gbl operator ==(const Vec1D& U, const Vec1D& V)
	{
		return U.Num() == V.Num();
	};
	bool I Gbl operator !=(const Vec1D& U, const Vec1D& V)
	{
		return !(U == V);
	};
	Vec1D I Gbl operator +(const Vec1D& V)
	{
		return V;
	};
	Vec1D I Gbl operator -(const Vec1D& V)
	{
		return Vec1D::Val(-V.Num());
	};
	Vec1D I Gbl operator +(const Vec1D& U, const Vec1D& V)
	{
		return Vec1D::Val(U.Num() + V.Num());
	};
	Vec1D I Gbl operator -(const Vec1D& U, const Vec1D& V)
	{
		return Vec1D::Val(U.Num() - V.Num());
	};
	Vec1D I Gbl operator *(const Vec1D& U, double V)
	{
		return Vec1D::Val(U.Num() * V);
	};
	Vec1D I Gbl operator *(double U, const Vec1D& V)
	{
		return Vec1D::Val(U * V.Num());
	};
	Vec1D I Gbl operator /(const Vec1D& U, double V)
	{
		return Vec1D::Val(U.Num() / V);
	};
	Vec1D& Ths Vec1D::operator +=(const Vec1D& O) &
	{
		return *this = *this + O;
	};
	Vec1D& Ths Vec1D::operator +=(const std::initializer_list<Vec1D>& O) &
	{
		for (std::initializer_list<Vec1D>::const_iterator ite = O.begin(); ite != O.end(); ++ite) { *this += *ite; }
		return *this;
	};
	Vec1D& Ths Vec1D::operator -=(const Vec1D& O) &
	{
		return *this = *this - O;
	};
	Vec1D& Ths Vec1D::operator -=(const std::initializer_list<Vec1D>& O) &
	{
		for (std::initializer_list<Vec1D>::const_iterator ite = O.begin(); ite != O.end(); ++ite) { *this -= *ite; }
		return *this;
	};
	Vec1D& Ths Vec1D::operator *=(double O) &
	{
		return *this = *this * O;
	};
	Vec1D& Ths Vec1D::operator *=(const std::initializer_list<double>& O) &
	{
		for (std::initializer_list<double>::const_iterator ite = O.begin(); ite != O.end(); ++ite) { *this *= *ite; }
		return *this;
	};
	Vec1D& Ths Vec1D::operator /=(double O) &
	{
		return *this = *this / O;
	};
	Vec1D& Ths Vec1D::operator /=(const std::initializer_list<double>& O) &
	{
		for (std::initializer_list<double>::const_iterator ite = O.begin(); ite != O.end(); ++ite) { *this /= *ite; }
		return *this;
	};
	///
	/// multiples
	///
	double Gbl Vec1D::Dot(const Vec1D& U, const Vec1D& V)
	{
		return Number::Dot(U.Num(), V.Num());
	};
	Vec1D Gbl Vec1D::Cross(const Vec1D& U, const Vec1D& V)
	{
		return Val(Number::Cross(U.Num(), V.Num()));
	};
	///
	/// fundamentals
	///
	double Gbl Vec1D::Abs(const Vec1D& V)
	{
		return Ev::Sqrt(Dot(V, V));
	};
	Vec1D Gbl Vec1D::Sgn(const Vec1D& V)
	{
		return V / Abs(V);
	};
	///
	/// conventions
	///
	String Gbl Vec1D::Str(const Vec1D& V)
	{
		std::wstring Rst = ToString(V, true, L"e1");
		return String{ Rst.data() };
	};
	Vec1D Gbl Vec1D::Val(const String& V)
	{
		std::wstring Str = Replace(V.Ptr(), L" ", L"");
		Vec1D Rst{};
		ToNumbers(Str, Rst, true, L"e1");
		return Rst;
	};
	struct I Cmplx
	{
		///
		/// constants
		///
	public:
		static const Cmplx Zero;
		static const Cmplx i;
		///
		/// basis
		///
	private:
		double Re;
		Vec1D Im;
	public:
		explicit Ths Cmplx();
		explicit Ths Cmplx(double s, const Vec1D& v);
		explicit Ths Cmplx(double s, double i);
		Ths Cmplx(double V);
		Ths Cmplx(const Vec1D& V);
		static double Gbl Scalar(const Cmplx& V);
		static Vec1D Gbl Vector(const Cmplx& V);
		///
		/// operators
		///
	public:
		Cmplx Ths operator ()() const;
		double& Ths operator [](std::size_t i) &;
		const double& Ths operator [](std::size_t i) const&;
		friend bool I Gbl operator ==(const Cmplx& U, const Cmplx& V);
		friend bool I Gbl operator !=(const Cmplx& U, const Cmplx& V);
		friend Cmplx I Gbl operator +(const Cmplx& V);
		friend Cmplx I Gbl operator -(const Cmplx& V);
		friend Cmplx I Gbl operator ~(const Cmplx& V);
		Cmplx& Ths operator ++() &;
		Cmplx Ths operator ++(int) &;
		Cmplx& Ths operator --() &;
		Cmplx Ths operator --(int) &;
		friend Cmplx I Gbl operator +(const Cmplx& U, const Cmplx& V);
		friend Cmplx I Gbl operator -(const Cmplx& U, const Cmplx& V);
		friend Cmplx I Gbl operator *(const Cmplx& U, const Cmplx& V);
		friend Cmplx I Gbl operator /(const Cmplx& U, const Cmplx& V);
		friend Cmplx I Gbl operator ^(const Cmplx& U, std::int64_t V);
		Cmplx& Ths operator +=(const Cmplx& O) &;
		Cmplx& Ths operator +=(const std::initializer_list<Cmplx>& O) &;
		Cmplx& Ths operator -=(const Cmplx& O) &;
		Cmplx& Ths operator -=(const std::initializer_list<Cmplx>& O) &;
		Cmplx& Ths operator *=(const Cmplx& O) &;
		Cmplx& Ths operator *=(const std::initializer_list<Cmplx>& O) &;
		Cmplx& Ths operator /=(const Cmplx& O) &;
		Cmplx& Ths operator /=(const std::initializer_list<Cmplx>& O) &;
		Cmplx& Ths operator ^=(std::int64_t O) &;
		Cmplx& Ths operator ^=(const std::initializer_list<std::int64_t>& O) &;
		///
		/// multiples
		///
	public:
		static double Gbl Dot(const Cmplx& U, const Cmplx& V);
		static Vec1D Gbl Outer(const Cmplx& U, const Cmplx& V);
		static Cmplx Gbl Even(const Cmplx& U, const Cmplx& V);
		static Vec1D Gbl Cross(const Cmplx& U, const Cmplx& V);
		///
		/// fundamentals
		///
	public:
		static double Gbl Abs(const Cmplx& V);
		static double Gbl Arg(const Cmplx& V, std::int64_t P);
		static double Gbl Arg(const Cmplx& V);
		static Cmplx Gbl Conjg(const Cmplx& V);
		static Cmplx Gbl Sgn(const Cmplx& V);
		static Cmplx Gbl Inverse(const Cmplx& V);
		static Cmplx Gbl Exp(const Cmplx& V);
		static Cmplx Gbl Ln(const Cmplx& V, std::int64_t P);
		static Cmplx Gbl Ln(const Cmplx& V);
		///
		/// exponentials
		///
	public:
		static Cmplx Gbl Power(const Cmplx& U, const Cmplx& V, std::int64_t z1);
		static Cmplx Gbl Power(const Cmplx& U, const Cmplx& V);
		static Cmplx Gbl Power(const Cmplx& U, double V, std::int64_t P);
		static Cmplx Gbl Power(const Cmplx& U, double V);
		static Cmplx Gbl Root(const Cmplx& U, const Cmplx& V, std::int64_t z1);
		static Cmplx Gbl Root(const Cmplx& U, const Cmplx& V);
		static Cmplx Gbl Root(const Cmplx& U, double V, std::int64_t P);
		static Cmplx Gbl Root(const Cmplx& U, double V);
		static Cmplx Gbl Log(const Cmplx& U, const Cmplx& V, std::int64_t z1, std::int64_t z2);
		static Cmplx Gbl Log(const Cmplx& U, const Cmplx& V);
		///
		/// trigonometrics
		///
	public:
		static Cmplx Gbl Sin(const Cmplx& V);
		static Cmplx Gbl Cos(const Cmplx& V);
		static Cmplx Gbl Tan(const Cmplx& V);
		static Cmplx Gbl Csc(const Cmplx& V);
		static Cmplx Gbl Sec(const Cmplx& V);
		static Cmplx Gbl Cot(const Cmplx& V);
		static Cmplx Gbl Sinh(const Cmplx& V);
		static Cmplx Gbl Cosh(const Cmplx& V);
		static Cmplx Gbl Tanh(const Cmplx& V);
		static Cmplx Gbl Csch(const Cmplx& V);
		static Cmplx Gbl Sech(const Cmplx& V);
		static Cmplx Gbl Coth(const Cmplx& V);
		static Cmplx Gbl Arcsin(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arcsin(const Cmplx& V);
		static Cmplx Gbl Arccos(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arccos(const Cmplx& V);
		static Cmplx Gbl Arctan(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arctan(const Cmplx& V);
		static Cmplx Gbl Arccsc(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arccsc(const Cmplx& V);
		static Cmplx Gbl Arcsec(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arcsec(const Cmplx& V);
		static Cmplx Gbl Arccot(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arccot(const Cmplx& V);
		static Cmplx Gbl Arcsinh(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arcsinh(const Cmplx& V);
		static Cmplx Gbl Arccosh(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arccosh(const Cmplx& V);
		static Cmplx Gbl Arctanh(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arctanh(const Cmplx& V);
		static Cmplx Gbl Arccsch(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arccsch(const Cmplx& V);
		static Cmplx Gbl Arcsech(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arcsech(const Cmplx& V);
		static Cmplx Gbl Arccoth(const Cmplx& V, bool S, std::int64_t P);
		static Cmplx Gbl Arccoth(const Cmplx& V);
		///
		/// conventions
		///
	public:
		static String Gbl Str(const Cmplx& V);
		static Cmplx Gbl Val(const String& V);
		///
		/// casing
		///
	public:
		Number Num() const&
		{
			return Number{ Re, Im[1] };
		};
		static Cmplx Val(const Number& N)
		{
			return Cmplx{ N[0], N[1] };
		};
	};
	/* struct Cmplx */
	///
	/// constants
	///
	const Cmplx Cmplx::Zero = Cmplx{ 0, Vec1D::Zero };
	const Cmplx Cmplx::i = Cmplx{ 0, Vec1D::e1 };
	///
	/// basis
	///
	Ths Cmplx::Cmplx()
		: Re{ 0 }, Im{ Vec1D::Zero }
	{};
	Ths Cmplx::Cmplx(double s, const Vec1D& v)
		: Re{ s }, Im{ v }
	{};
	Ths Cmplx::Cmplx(double s, double i)
		: Re{ s }, Im{ i }
	{};
	Ths Cmplx::Cmplx(double V)
		: Re{ V }, Im{ Vec1D::Zero }
	{};
	Ths Cmplx::Cmplx(const Vec1D& V)
		: Re{ 0 }, Im{ V }
	{};
	double Gbl Cmplx::Scalar(const Cmplx& V)
	{
		return V.Re;
	};
	Vec1D Gbl Cmplx::Vector(const Cmplx& V)
	{
		return V.Im;
	};
	///
	/// operators
	///
	Cmplx Ths Cmplx::operator ()() const
	{
		return *this;
	};
	double& Ths Cmplx::operator [](std::size_t i) &
	{
		switch (i)
		{
		case 0: return Re;
		default: return Im[i];
		}
	};
	const double& Ths Cmplx::operator [](std::size_t i) const&
	{
		switch (i)
		{
		case 0: return Re;
		default: return Im[i];
		}
	};
	bool I Gbl operator ==(const Cmplx& U, const Cmplx& V)
	{
		return U.Num() == V.Num();
	};
	bool I Gbl operator !=(const Cmplx& U, const Cmplx& V)
	{
		return !(U == V);
	};
	Cmplx I Gbl operator +(const Cmplx& V)
	{
		return V;
	};
	Cmplx I Gbl operator -(const Cmplx& V)
	{
		return Cmplx::Val(-V.Num());
	};
	Cmplx I Gbl operator ~(const Cmplx& V)
	{
		return Cmplx::Val(~V.Num());
	};
	Cmplx& Ths Cmplx::operator ++() &
	{
		++(*this)[0];
		return *this;
	};
	Cmplx Ths Cmplx::operator ++(int) &
	{
		Cmplx Rst = *this;
		++(*this)[0];
		return Rst;
	};
	Cmplx& Ths Cmplx::operator --() &
	{
		--(*this)[0];
		return *this;
	};
	Cmplx Ths Cmplx::operator --(int) &
	{
		Cmplx Rst = *this;
		--(*this)[0];
		return Rst;
	};
	Cmplx I Gbl operator +(const Cmplx& U, const Cmplx& V)
	{
		return Cmplx::Val(U.Num() + V.Num());
	};
	Cmplx I Gbl operator -(const Cmplx& U, const Cmplx& V)
	{
		return Cmplx::Val(U.Num() - V.Num());
	};
	Cmplx I Gbl operator *(const Cmplx& U, const Cmplx& V)
	{
		return Cmplx::Val(U.Num() * V.Num());
	};
	Cmplx I Gbl operator /(const Cmplx& U, const Cmplx& V)
	{
		if (Cmplx::Vector(V) == Cmplx::Zero) { return Cmplx::Val(U.Num() / Cmplx::Scalar(V)); }
		return U * Cmplx::Inverse(V);
	};
	Cmplx I Gbl operator ^(const Cmplx& U, std::int64_t V)
	{
		return Cmplx::Power(U, static_cast<double>(V));
	};
	Cmplx& Ths Cmplx::operator +=(const Cmplx& O) &
	{
		return *this = *this + O;
	};
	Cmplx& Ths Cmplx::operator +=(const std::initializer_list<Cmplx>& O) &
	{
		for (std::initializer_list<Cmplx>::const_iterator ite = O.begin(); ite != O.end(); ++ite) { *this += *ite; }
		return *this;
	};
	Cmplx& Ths Cmplx::operator -=(const Cmplx& O) &
	{
		return *this = *this - O;
	};
	Cmplx& Ths Cmplx::operator -=(const std::initializer_list<Cmplx>& O) &
	{
		for (std::initializer_list<Cmplx>::const_iterator ite = O.begin(); ite != O.end(); ++ite) { *this -= *ite; }
		return *this;
	};
	Cmplx& Ths Cmplx::operator *=(const Cmplx& O) &
	{
		return *this = *this * O;
	};
	Cmplx& Ths Cmplx::operator *=(const std::initializer_list<Cmplx>& O) &
	{
		for (std::initializer_list<Cmplx>::const_iterator ite = O.begin(); ite != O.end(); ++ite) { *this *= *ite; }
		return *this;
	};
	Cmplx& Ths Cmplx::operator /=(const Cmplx& O) &
	{
		return *this = *this / O;
	};
	Cmplx& Ths Cmplx::operator /=(const std::initializer_list<Cmplx>& O) &
	{
		for (std::initializer_list<Cmplx>::const_iterator ite = O.begin(); ite != O.end(); ++ite) { *this /= *ite; }
		return *this;
	};
	Cmplx& Ths Cmplx::operator ^=(std::int64_t O) &
	{
		return *this = *this ^ O;
	};
	Cmplx& Ths Cmplx::operator ^=(const std::initializer_list<std::int64_t>& O) &
	{
		for (std::initializer_list<std::int64_t>::const_iterator ite = O.begin(); ite != O.end(); ++ite) { *this ^= *ite; }
		return *this;
	};
	///
	/// multiples
	///
	double Gbl Cmplx::Dot(const Cmplx& U, const Cmplx& V)
	{
		return Number::Dot(U.Num(), V.Num());
	};
	Vec1D Gbl Cmplx::Outer(const Cmplx& U, const Cmplx& V)
	{
		return Vec1D::Val(Number::Outer(U.Num(), V.Num()));
	};
	Cmplx Gbl Cmplx::Even(const Cmplx& U, const Cmplx& V)
	{
		return Val(Number::Even(U.Num(), V.Num()));
	};
	Vec1D Gbl Cmplx::Cross(const Cmplx& U, const Cmplx& V)
	{
		return Vec1D::Val(Number::Cross(U.Num(), V.Num()));
	};
	///
	/// fundamentals
	///
	double Gbl Cmplx::Abs(const Cmplx& V)
	{
		return Ev::Sqrt(Dot(V, V));
	};
	double Gbl Cmplx::Arg(const Cmplx& V, std::int64_t P)
	{
		return Ev::Arccos(Scalar(V) / Abs(V)) + 2 * Ev::PI * static_cast<double>(P);
	};
	double Gbl Cmplx::Arg(const Cmplx& V)
	{
		return Arg(V, 0);
	};
	Cmplx Gbl Cmplx::Conjg(const Cmplx& V)
	{
		return ~V;
	};
	Cmplx Gbl Cmplx::Sgn(const Cmplx& V)
	{
		return V / Abs(V);
	};
	Cmplx Gbl Cmplx::Inverse(const Cmplx& V)
	{
		return Conjg(V) / Dot(V, V);
	};
	Cmplx Gbl Cmplx::Exp(const Cmplx& V)
	{
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		if (Im == Vec1D::Zero) { return Ev::Exp(Re); }
		double Sz = Abs(Im);
		Cmplx Or = Sgn(Im);
		return Ev::Exp(Re) * (Ev::Cos(Sz) + Or * Ev::Sin(Sz));
	};
	Cmplx Gbl Cmplx::Ln(const Cmplx& V, std::int64_t P)
	{
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		if (Im == Vec1D::Zero)
		{
			if (Re >= 0) { return Ev::Ln(Re) + 2 * static_cast<double>(P) * Ev::PI * i; }
			else { return Ev::Ln(-Re) + (2 * static_cast<double>(P) + 1) * Ev::PI * i; }
		}
		Cmplx Or = Sgn(Im);
		return Ev::Ln(Abs(V)) + Or * Arg(V, P);
	};
	Cmplx Gbl Cmplx::Ln(const Cmplx& V)
	{
		return Ln(V, 0);
	};
	///
	/// exponentials
	///
	Cmplx Gbl Cmplx::Power(const Cmplx& U, const Cmplx& V, std::int64_t z1)
	{
		return Exp(V * Ln(U, z1));
	};
	Cmplx Gbl Cmplx::Power(const Cmplx& U, const Cmplx& V)
	{
		return Power(U, V, 0);
	};
	Cmplx Gbl Cmplx::Power(const Cmplx& U, double V, std::int64_t P)
	{
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		if (Im == Vec1D::Zero)
		{
			if (Re >= 0)
			{
				double Ai = 2 * static_cast<double>(P) * Ev::PI * V;
				return Ev::Power(Re, V) * (Ev::Cos(Ai) + i * Ev::Sin(Ai));
			}
			else
			{
				double Ai = (2 * static_cast<double>(P) + 1) * Ev::PI * V;
				return Ev::Power(-Re, V) * (Ev::Cos(Ai) + i * Ev::Sin(Ai));
			}
		}
		Cmplx Or = Sgn(Im);
		double A = Arg(U, P) * V;
		return Ev::Power(Abs(U), V) * (Ev::Cos(A) + Or * Ev::Sin(A));
	};
	Cmplx Gbl Cmplx::Power(const Cmplx& U, double V)
	{
		return Power(U, V, 0);
	};
	Cmplx Gbl Cmplx::Root(const Cmplx& U, const Cmplx& V, std::int64_t z1)
	{
		return Power(U, Inverse(V), z1);
	};
	Cmplx Gbl Cmplx::Root(const Cmplx& U, const Cmplx& V)
	{
		return Root(U, V, 0);
	};
	Cmplx Gbl Cmplx::Root(const Cmplx& U, double V, std::int64_t P)
	{
		return Power(U, 1 / V, P);
	};
	Cmplx Gbl Cmplx::Root(const Cmplx& U, double V)
	{
		return Root(U, V, 0);
	};
	Cmplx Gbl Cmplx::Log(const Cmplx& U, const Cmplx& V, std::int64_t z1, std::int64_t z2)
	{
		return Ln(V, z1) / Ln(U, z2);
	};
	Cmplx Gbl Cmplx::Log(const Cmplx& U, const Cmplx& V)
	{
		return Log(U, V, 0, 0);
	};
	///
	/// trigonometrics
	///
	Cmplx Gbl Cmplx::Sin(const Cmplx& V)
	{
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		if (Im == Vec1D::Zero) { return Ev::Sin(Re); }
		double Sz = Abs(Im);
		Cmplx Or = Sgn(Im);
		return Ev::Sin(Re) * Ev::Cosh(Sz) + Ev::Cos(Re) * Ev::Sinh(Sz) * Or;
	};
	Cmplx Gbl Cmplx::Cos(const Cmplx& V)
	{
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		if (Im == Vec1D::Zero) { return Ev::Cos(Re); }
		double Sz = Abs(Im);
		Cmplx Or = Sgn(Im);
		return Ev::Cos(Re) * Ev::Cosh(Sz) - Ev::Sin(Re) * Ev::Sinh(Sz) * Or;
	};
	Cmplx Gbl Cmplx::Tan(const Cmplx& V)
	{
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		double T = Ev::Tan(Re);
		if (Im == Vec1D::Zero) { return T; }
		double Sz = Abs(Im);
		Cmplx Or = Sgn(Im);
		double Th = Ev::Tanh(Sz);
		double T2 = T * T;
		double Th2 = Th * Th;
		return (T * (1 - Th2) + Th * (1 + T2) * Or) / (1 + T2 * Th2);
	};
	Cmplx Gbl Cmplx::Csc(const Cmplx& V)
	{
		return Inverse(Sin(V));
	};
	Cmplx Gbl Cmplx::Sec(const Cmplx& V)
	{
		return Inverse(Cos(V));
	};
	Cmplx Gbl Cmplx::Cot(const Cmplx& V)
	{
		return Inverse(Tan(V));
	};
	Cmplx Gbl Cmplx::Sinh(const Cmplx& V)
	{
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		if (Im == Vec1D::Zero) { return Ev::Sinh(Re); }
		double Sz = Abs(Im);
		Cmplx Or = Sgn(Im);
		return Ev::Sinh(Re) * Ev::Cos(Sz) + Ev::Cosh(Re) * Ev::Sin(Sz) * Or;
	};
	Cmplx Gbl Cmplx::Cosh(const Cmplx& V)
	{
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		if (Im == Vec1D::Zero) { return Ev::Cosh(Re); }
		double Sz = Abs(Im);
		Cmplx Or = Sgn(Im);
		return Ev::Cosh(Re) * Ev::Cos(Sz) + Ev::Sinh(Re) * Ev::Sin(Sz) * Or;
	};
	Cmplx Gbl Cmplx::Tanh(const Cmplx& V)
	{
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		double Th = Ev::Tanh(Re);
		if (Im == Vec1D::Zero) { return Th; }
		double Sz = Abs(Im);
		Cmplx Or = Sgn(Im);
		double T = Ev::Tan(Sz);
		double Th2 = Th * Th;
		double T2 = T * T;
		return (Th * (1 - T2) + T * (1 + Th2) * Or) / (1 + Th2 * T2);
	};
	Cmplx Gbl Cmplx::Csch(const Cmplx& V)
	{
		return Inverse(Sinh(V));
	};
	Cmplx Gbl Cmplx::Sech(const Cmplx& V)
	{
		return Inverse(Cosh(V));
	};
	Cmplx Gbl Cmplx::Coth(const Cmplx& V)
	{
		return Inverse(Tanh(V));
	};
	Cmplx Gbl Cmplx::Arcsin(const Cmplx& V, bool S, std::int64_t P)
	{
		if (!S) { return Ev::PI - Arcsin(V, true, P); }
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		if (Im == Vec1D::Zero) { return -i * Ln(i * Re + Root(1 - Re * Re, 2), P); }
		Cmplx Or = Sgn(Im);
		return -Or * Ln(Or * V + Root(1 - V * V, 2), P);
	};
	Cmplx Gbl Cmplx::Arcsin(const Cmplx& V)
	{
		return Arcsin(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arccos(const Cmplx& V, bool S, std::int64_t P)
	{
		if (!S) { return 2 * Ev::PI - Arccos(V, true, P); }
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		if (Im == Vec1D::Zero) { return -i * Ln(Re + Root(Re * Re - 1, 2), P); }
		Cmplx Or = Sgn(Im);
		return -Or * Ln(V + Root(V * V - 1, 2), P);
	};
	Cmplx Gbl Cmplx::Arccos(const Cmplx& V)
	{
		return Arccos(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arctan(const Cmplx& V, bool S, std::int64_t P)
	{
		if (!S) { return Ev::PI + Arctan(V, true, P); }
		double Re = Scalar(V);
		Vec1D Im = Vector(V);
		if (Im == Vec1D::Zero) { return 2 * Ev::PI * static_cast<double>(P) + i * (Ln(1 - i * Re) - Ln(1 + i * Re)) / 2; }
		Cmplx Or = Sgn(Im);
		return 2 * Ev::PI * static_cast<double>(P) + Or * (Ln(1 - Or * V) - Ln(1 + Or * V)) / 2;
	};
	Cmplx Gbl Cmplx::Arctan(const Cmplx& V)
	{
		return Arctan(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arccsc(const Cmplx& V, bool S, std::int64_t P)
	{
		return Arcsin(Inverse(V), S, P);
	};
	Cmplx Gbl Cmplx::Arccsc(const Cmplx& V)
	{
		return Arccsc(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arcsec(const Cmplx& V, bool S, std::int64_t P)
	{
		return Arccos(Inverse(V), S, P);
	};
	Cmplx Gbl Cmplx::Arcsec(const Cmplx& V)
	{
		return Arcsec(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arccot(const Cmplx& V, bool S, std::int64_t P)
	{
		return Arctan(Inverse(V), S, P);
	};
	Cmplx Gbl Cmplx::Arccot(const Cmplx& V)
	{
		return Arccot(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arcsinh(const Cmplx& V, bool S, std::int64_t P)
	{
		Vec1D Im = Vector(V);
		Cmplx Or = Sgn(Im);
		if (!S) { return Ev::PI * Or - Arcsinh(V, true, P); }
		return Ln(V + Root(V * V + 1, 2), P);
	};
	Cmplx Gbl Cmplx::Arcsinh(const Cmplx& V)
	{
		return Arcsinh(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arccosh(const Cmplx& V, bool S, std::int64_t P)
	{
		Vec1D Im = Vector(V);
		Cmplx Or = Sgn(Im);
		if (!S) { return 2 * Ev::PI * Or - Arccosh(V, true, P); }
		return Ln(V + Root(V * V - 1, 2), P);
	};
	Cmplx Gbl Cmplx::Arccosh(const Cmplx& V)
	{
		return Arccosh(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arctanh(const Cmplx& V, bool S, std::int64_t P)
	{
		Vec1D Im = Vector(V);
		Cmplx Or = Sgn(Im);
		if (!S) { return Ev::PI * Or + Arctan(V, true, P); }
		return 2 * Ev::PI * static_cast<double>(P) * Or + (Ln(1 + V) - Ln(1 - V)) / 2;
	};
	Cmplx Gbl Cmplx::Arctanh(const Cmplx& V)
	{
		return Arctanh(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arccsch(const Cmplx& V, bool S, std::int64_t P)
	{
		return Arcsinh(Inverse(V), S, P);
	};
	Cmplx Gbl Cmplx::Arccsch(const Cmplx& V)
	{
		return Arccsch(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arcsech(const Cmplx& V, bool S, std::int64_t P)
	{
		return Arccosh(Inverse(V), S, P);
	};
	Cmplx Gbl Cmplx::Arcsech(const Cmplx& V)
	{
		return Arcsech(V, true, 0);
	};
	Cmplx Gbl Cmplx::Arccoth(const Cmplx& V, bool S, std::int64_t P)
	{
		return Arctanh(Inverse(V), S, P);
	};
	Cmplx Gbl Cmplx::Arccoth(const Cmplx& V)
	{
		return Arccoth(V, true, 0);
	};
	///
	/// conventions
	///
	String Gbl Cmplx::Str(const Cmplx& V)
	{
		std::wstring Rst = ToString(V, false, L"", L"i");
		return String{ Rst.data() };
	};
	Cmplx Gbl Cmplx::Val(const String& V)
	{
		std::wstring Str = Replace(V.Ptr(), L" ", L"");
		Cmplx Rst{};
		ToNumbers(Str, Rst, false, L"", L"i");
		return Rst;
	};
}
#pragma pop_macro("Ths")
#pragma pop_macro("Gbl")
#pragma pop_macro("I")
#pragma pack(pop)
