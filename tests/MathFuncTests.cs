﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace csharpcore
{
	[TestFixture]
	public class MathFuncTests
	{
		MathFunc mathFunc1 = new MathFunc();

		[Test]
		public void MultiplyTest()
		{
			int a = 1;
			int b = 5;
			int c = 0;
			int d = -1;
			int e = -5;

			Assert.AreEqual(5, mathFunc1.Multiply(a, b));
			Assert.AreEqual(5, mathFunc1.Multiply(b, a));
			Assert.AreEqual(-5, mathFunc1.Multiply(b, d));
			Assert.AreEqual(5, mathFunc1.Multiply(d, e));
			Assert.AreEqual(0, mathFunc1.Multiply(c, e));
			Assert.AreEqual(0, mathFunc1.Multiply(e, c));
			Assert.AreEqual(-25, mathFunc1.Multiply(b, e));
		}

		[Test]
		public void DivideTest()
		{
			int a = 1;
			int b = 5;
			int c = 0;
			int d = -1;
			int e = -5;

			Assert.AreEqual(0.2, mathFunc1.Divide(a, b));
			Assert.AreEqual(5, mathFunc1.Divide(b, a));
			Assert.AreEqual(-5, mathFunc1.Divide(b, d));
			Assert.AreEqual(0.2, mathFunc1.Divide(d, e));
			Assert.AreEqual(0, mathFunc1.Divide(c, e));
			Assert.AreEqual(-1, mathFunc1.Divide(b, e));
		}

		[Test]
		public void AdditionTest()
		{
			int a = 1;
			int b = 5;
			int c = 0;
			int d = -1;
			int e = -5;

			Assert.AreEqual(6, mathFunc1.Addition(a, b));
			Assert.AreEqual(6, mathFunc1.Addition(b, a));
			Assert.AreEqual(4, mathFunc1.Addition(b, d));
			Assert.AreEqual(-6, mathFunc1.Addition(d, e));
			Assert.AreEqual(-5, mathFunc1.Addition(c, e));
			Assert.AreEqual(0, mathFunc1.Addition(b, e));
		}

		[Test]
		public void SubstractionTest()
		{
			int a = 1;
			int b = 5;
			int c = 0;
			int d = -1;
			int e = -5;

			Assert.AreEqual(-4, mathFunc1.Substraction(a, b));
			Assert.AreEqual(4, mathFunc1.Substraction(b, a));
			Assert.AreEqual(6, mathFunc1.Substraction(b, d));
			Assert.AreEqual(4, mathFunc1.Substraction(d, e));
			Assert.AreEqual(5, mathFunc1.Substraction(c, e));
			Assert.AreEqual(10, mathFunc1.Substraction(b, e));
		}

		[Test]
		public void PoweringTest()
		{
			int a = 1;
			int b = 2;
			int c = 3;
			int d = 5;
			int e = 10;
			int f = 5;

			Assert.AreEqual(1, mathFunc1.Powering(a, b));
			Assert.AreEqual(25, mathFunc1.Powering(f, b));
			Assert.AreEqual(243, mathFunc1.Powering(c, d));
			Assert.AreEqual(100000, mathFunc1.Powering(e, d));
			Assert.AreEqual(59049, mathFunc1.Powering(c, e));
			Assert.AreEqual(9765625, mathFunc1.Powering(f, e));
		}

		[Test]
		public void AbsoluteTest()
		{
			int a = 1;
			int b = -2;
			int c = 3;
			int d = -5;
			int e = 10;
			int f = 5;
			Assert.AreEqual(1, mathFunc1.Absolute(a, b));
			Assert.AreEqual(3, mathFunc1.Absolute(f, b));
			Assert.AreEqual(2, mathFunc1.Absolute(c, d));
			Assert.AreEqual(0, mathFunc1.Absolute(f, d));
			Assert.AreEqual(13, mathFunc1.Absolute(c, e));
		}

		[Test]
		public void ReturnMaxTest()
		{
			int a = 1;
			int b = -2;
			int c = 3;
			int d = -5;
			int e = 0;
			int f = 5;
			Assert.AreEqual(a, mathFunc1.ReturnMax(a, b));
			Assert.AreEqual(f, mathFunc1.ReturnMax(f, b));
			Assert.AreEqual(c, mathFunc1.ReturnMax(c, d));
			Assert.AreEqual(f, mathFunc1.ReturnMax(f, d));
			Assert.AreEqual(c, mathFunc1.ReturnMax(c, e));
		}

		[Test]
		public void ReturnMinTest()
		{
			int a = 1;
			int b = -2;
			int c = 3;
			int d = -5;
			int e = 0;
			int f = 5;
			Assert.AreEqual(b, mathFunc1.ReturnMin(a, b));
			Assert.AreEqual(b, mathFunc1.ReturnMin(f, b));
			Assert.AreEqual(d, mathFunc1.ReturnMin(c, d));
			Assert.AreEqual(d, mathFunc1.ReturnMin(f, d));
			Assert.AreEqual(e, mathFunc1.ReturnMin(c, e));
		}

		[Test]
		public void ReturnAverageTest()
		{
			int a = 1;
			int b = -2;
			int c = 3;
			int d = -5;
			int e = 0;
			int f = 5;
			Assert.AreEqual(-0.5f, mathFunc1.ReturnAverage(a, b));
			Assert.AreEqual(1.5, mathFunc1.ReturnAverage(f, b));
			Assert.AreEqual(-1, mathFunc1.ReturnAverage(c, d));
			Assert.AreEqual(0, mathFunc1.ReturnAverage(f, d));
			Assert.AreEqual(1.5, mathFunc1.ReturnAverage(c, e));
		}
	}
}
