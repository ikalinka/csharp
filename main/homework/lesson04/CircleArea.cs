using System;
namespace csharpcore
{
	public class CircleArea
	{
		public const double PI = 3.14d;
		public static void CalculateBigger()
		{
			double area1, area2;

			Console.WriteLine("Enter size of Circle Area 1: ");
			area1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter size of Circle Area 1: ");
			area2 = Convert.ToDouble(Console.ReadLine());

			if (area1 > area2)
			{
				Console.WriteLine("Area 1 is bigger.");
			}
			else
			{
				Console.WriteLine("Area 2 is bigger.");
			}
		}
	}
}

