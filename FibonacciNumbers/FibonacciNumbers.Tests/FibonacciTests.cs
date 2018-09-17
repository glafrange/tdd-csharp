using System;
using NUnit.Framework;

namespace FibonacciNumbers.Tests
{
	[TestFixture]
    public class FibonacciTests
    {
		[Test]
		public void WhenOneReturnsOne()
		{
			Assert.AreEqual(FibonacciNumbers.GetFib(1), 1);
		}

		[Test]
		public void WhenThreeReturnsTwo()
		{
			Assert.AreEqual(FibonacciNumbers.GetFib(3), 2);
		}

		[Test]
		public void WhenFiveReturnsFive()
		{
			Assert.AreEqual(FibonacciNumbers.GetFib(5), 5);
		}
    }
}
