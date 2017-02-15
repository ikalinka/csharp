using System;
namespace csharpcore
{
	public class OddOrEven
	{
		public static void CheckOddOrEven()
		{
			int a;
			Console.WriteLine("Input any integer digit: ");
			a = Convert.ToInt16(Console.ReadLine());
			if (a % 2 == 0 && a != 0)
			{
				Console.WriteLine("You've entered Even digit");
			}
			else
			{
				Console.WriteLine("You've entered Odd digit");
			}
		}
	}
}

