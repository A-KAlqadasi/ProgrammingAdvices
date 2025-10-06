using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithLinqAggregateFunction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


			// Filtering to get only even numbers
			var evenNumbers = numbers.Where(n => n % 2 == 0).OrderByDescending(n=>n);

			

			// Aggregating - calculating the sum of even numbers
			int sumOfEvenNumbers = evenNumbers.Sum();


			// Displaying the results
			Console.WriteLine("Even Numbers:");
			foreach (var num in evenNumbers)
			{
				Console.Write(num + " ");
			}
			Console.WriteLine($"\nSum of Even Numbers: {sumOfEvenNumbers}");
			Console.ReadKey();




			Console.ReadKey();
		}
	}
}
