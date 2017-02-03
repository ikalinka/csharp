using System;

namespace csharpcore
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			PrimitiveConvertor convertFloatToChar = new PrimitiveConvertor();
			convertFloatToChar.floatToChar(122.1f);
			PrimitiveConvertor convertIntToChar = new PrimitiveConvertor();
			convertIntToChar.intToChar(122);
			PrimitiveConvertor convertCharToInt = new PrimitiveConvertor();
			convertCharToInt.charToInt('%');
		}
	}
}
