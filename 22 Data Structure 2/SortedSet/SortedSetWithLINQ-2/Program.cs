using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetWithLINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SortedSet<int> numbers = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// Squares of even numbers

			var squaresOfEvenNumbers = numbers.Where(n=> n % 2 == 0).Select(n=>n * n);
            Console.WriteLine("Squares of even numbers:");
            foreach (int n in squaresOfEvenNumbers)
			{
                Console.Write(n + " ");
            }

			Console.ReadKey();
		}
	}
}
