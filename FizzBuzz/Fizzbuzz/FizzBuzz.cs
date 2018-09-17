using System;

namespace Fizzbuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

	public class FizzBuzzer
	{
		static public string CheckNumber(int number)
		{
			//return number % 3 == 0 ? "Fizz" : number.ToString();
			if (number % 3 == 0 && number % 5 == 0)
			{
				return "FizzBuzz";
			}
			else if (number % 3 == 0)
			{
				return "Fizz";
			}
			else if (number % 5 == 0)
			{
				return "Buzz";
			}
			else
			{
				return number.ToString();
			}
		}
	}
}
