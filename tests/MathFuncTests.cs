using System;
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

	}
}
