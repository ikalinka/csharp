using System;
namespace csharpcore
{
	public class TriangleChecker
	{
		public static void RightTriangleChecker()
		{
			double a, b, c;
			Console.WriteLine("Please enter length of triangle sides: ");
			Console.WriteLine("Enter length of side 'A'");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter length of side 'B'");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter length of side 'C'");
			c = Convert.ToDouble(Console.ReadLine());

			if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (a * a == b * b + c * c))
			{
				Console.WriteLine("This is a right-triangle");
			}
			else
			{
				Console.WriteLine("This is not a right-triangle");
			}

		}
	}
}
