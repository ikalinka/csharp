using System;
namespace csharpcore
{
	public class PrimitiveConvertor
	{
		int intVar;
		char charVar;
		public char floatToChar(float floatVar)
		{
			charVar = (char) floatVar;
			Console.WriteLine("Input float value is " + floatVar
			+ ". Output char value is " + charVar);
			return charVar;
		}
		public char intToChar(int intVar)
		{
			charVar = (char)intVar;
			Console.WriteLine("Input int value is " + intVar
			+ ". Output char value is " + charVar);
			return charVar;
		}
		public int charToInt(char charVar)
		{
			intVar = (int) charVar;
			Console.WriteLine("Input char value is " + charVar
			+ ". Output int value is " + intVar);
			return intVar;
		}
	}
}
