using System;
using NUnit.Framework;

namespace RomanNumeralParser
{
	[TestFixture]
	public class RomanNumeralParserTests
	{
		[Test]
		public void Input_I_Returns_1()
		{
			Assert.AreEqual(RomanNumeralParser.Parse("I"), 1);
		}

		[TestCase("I", 1)]
		[TestCase("V", 5)]
		[TestCase("X", 10)]
		[TestCase("L", 50)]
		[TestCase("C", 100)]
		[TestCase("D", 500)]
		[TestCase("M", 1000)]
		public void TestSingleNumeral(string input, int expectedOutput)
		{
			Assert.AreEqual(RomanNumeralParser.Parse(input), expectedOutput);
		}

		[TestCase("IV", 4)]
		[TestCase("IX", 9)]
		[TestCase("XL", 40)]
		[TestCase("IL", 49)]
		[TestCase("XD", 490)]
		public void TestSubtractiveNotation(string input, int expectedOutput)
		{
			Assert.AreEqual(RomanNumeralParser.Parse(input), expectedOutput);
		}
		
		[TestCase("MCDXXIII", 1423)]
		[TestCase("DCCXCIII", 793)]
		[TestCase("CCCXXV", 325)]
		[TestCase("MMMDCXLIX", 3649)]
		public void TestComplexNumerals(string input, int expectedOutput)
		{
			Assert.AreEqual(expectedOutput, RomanNumeralParser.Parse(input));
		}
	}
}
