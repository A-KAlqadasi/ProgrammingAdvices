using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithLinq
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Array of numbers
			int[] numbers = { 1, 2, 3, 4, 5 };

			var squareEvenNumbers = numbers.Where(n=>n % 2 == 0).Select(n=>n*n);

            Console.WriteLine("Square of even numbers in array");
            foreach (var number in squareEvenNumbers)
			{
                Console.Write(number + " ");
            }

			Console.ReadKey();
		}
	}
}
