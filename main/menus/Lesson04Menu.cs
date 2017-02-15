using System;
namespace csharpcore
{
	public class Lesson04Runner
	{
		public static void Main()
		{
			int menuChoice;
			Console.WriteLine("Please select any item from the menu below with pressing respective number: ");
			Console.WriteLine("================================================");
			Console.WriteLine("= 1. Odd or Even                               =");
			Console.WriteLine("= 2. Circle area comparator                    =");
			Console.WriteLine("= 3. Right-Triangle checker                    =");
			Console.WriteLine("= 4. Circle area calculator                    =");
			Console.WriteLine("================================================");
			Console.WriteLine("= Press any key to exit                        =");
			Console.WriteLine("================================================");
			menuChoice = Convert.ToInt16(Console.ReadLine());

			if (menuChoice == 1)
			{
				OddOrEven.CheckOddOrEven();
			}
			else if (menuChoice == 2)
			{
				CircleArea.CalculateBigger();
			}
			else if (menuChoice == 3)
			{
				TriangleChecker.RightTriangleChecker();
			}
			else if (menuChoice == 4)
			{
				CirleRadius.Calculate();
			}
			else
			{
				Console.WriteLine("Your choice has not matched any suggested item. ");
			}
		}
	}
}

