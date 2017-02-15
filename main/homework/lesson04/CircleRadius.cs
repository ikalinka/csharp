using System;
namespace csharpcore
{
	public class CirleRadius
	{
		static double radius, pi, circleArea;
		public static void Calculate()
		{
			Console.WriteLine("Enter radius: ");
			radius = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter pi value: ");
			pi = Convert.ToDouble(Console.ReadLine());
			circleArea = pi * (radius * radius);
			Console.WriteLine("Circle Area is: " + circleArea);
		}
	}
}



