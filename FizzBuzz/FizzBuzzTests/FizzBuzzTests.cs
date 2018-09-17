using System;
using NUnit.Framework;

namespace FizzBuzzTests
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void DefaultOutputTest([Values(1,2,4,13,47)] int input)
		{
			Assert.AreEqual(Fizzbuzz.FizzBuzzer.CheckNumber(input), input.ToString());
		}

		[Test]
		public void FizzOutputTest([Values(3,6,9,18,24)] int input)
		{
			Assert.AreEqual(Fizzbuzz.FizzBuzzer.CheckNumber(input), "Fizz");
		}

		[Test]
		public void BuzzOutputTest([Values(5, 10, 25, 40, 65)] int input)
		{
			Assert.AreEqual(Fizzbuzz.FizzBuzzer.CheckNumber(input), "Buzz");
		}

		[Test]
		public void FizzBuzzOutputTest([Values(15,30,45,60,75)] int input)
		{
			Assert.AreEqual(Fizzbuzz.FizzBuzzer.CheckNumber(input), "FizzBuzz");
		}

    }
}
