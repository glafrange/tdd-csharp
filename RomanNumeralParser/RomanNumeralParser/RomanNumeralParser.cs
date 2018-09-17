using System;
using System.Collections.Generic;

namespace RomanNumeralParser
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(RomanNumeralParser.Parse("MCDXXIII"));
		}
	}

	public class RomanNumeralParser
	{
		private static Dictionary<char, int> numeralValues = 
			new Dictionary<char, int>()
			{
				{'I', 1 },
				{'V', 5 },
				{'X', 10 },
				{'L', 50 },
				{'C', 100 },
				{'D', 500 },
				{'M', 1000 }
			};

		public static int Parse(string numeralsInput)
		{
			char[] numerals = numeralsInput.ToCharArray();

			int sum = 0;

			for (int index = 0; index < numerals.Length; index++)
			{
				int numeralValue = numeralValues[numerals[index]];
				int nextNumeralValue = 0;

				if (index + 1 < numerals.Length)
					nextNumeralValue = numeralValues[numerals[index + 1]];

				if (numeralValue < nextNumeralValue)
				{
					sum += nextNumeralValue - numeralValue;
					index++;
				}
				else
				{
					sum += numeralValue;
				}

			}

			return sum;
		}
	}
}
