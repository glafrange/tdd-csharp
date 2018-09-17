using System;

namespace FibonacciNumbers
{
    public class FibonacciNumbers
    {
        static void Main(string[] args)
        {
			Console.WriteLine("enter num");
			var num = Console.ReadLine();
			var fib = GetFib(Convert.ToInt32(num));
			Console.WriteLine("The {0} number in the fibonacci sequence is: {1}", num, fib);
        }

		public static int GetFib(int index)
		{
			var current = 1;
			var last = 1;

			for (int i = 2; i < index; i++)
			{
				current += last;
				last = current - last;
			}

			return current;
		}
    }
}
