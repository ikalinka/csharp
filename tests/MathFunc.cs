using System;
namespace csharpcore
{
	public class MathFunc
	{
		public int Multiply(int a, int b)
		{
			return a * b;
		}

		public double Divide(int a, int b)
		{
			return (double) a / b;
		}

		public int Addition(int a, int b)
		{
			return a + b;
		}

		public int Substraction(int a, int b)
		{
			return a - b;
		}

		public int Powering(int a, int b)
		{
			int c = a;
			for (int i = 1; i < b; i++)
			{
				a *= c;
			}
			return a;
		}

		public int Absolute(int a, int b)
		{
			int result = 0;
			result = a + b;
			if (result < 0)
			{
				result = result * (-1);
			}
			return result;
		}

		public int ReturnMax(int a, int b)
		{
			if (a > b)
			{
				return a;
			}
			return b;
		}

		public int ReturnMin(int a, int b)
		{
			if (a < b)
			{
				return a;
			}
			return b;
		}

		public float ReturnAverage(float a, float b)
		{
			float result = 0.0f;

			result = (a + b) / 2;
			return result;
		}
	}
}
