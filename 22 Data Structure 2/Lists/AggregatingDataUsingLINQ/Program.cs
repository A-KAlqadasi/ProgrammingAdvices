using System;
using System.Collections.Generic;
using System.Linq;


namespace AggregatingDataUsingLINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			Console.WriteLine($"Sum: {numbers.Sum()}");
			Console.WriteLine($"Min: {numbers.Min()}");
			Console.WriteLine($"Max: {numbers.Max()}");
			Console.WriteLine($"Average: {numbers.Average()}");
			Console.WriteLine($"Count: {numbers.Count()}");

			Console.ReadKey();
		}
	}
}
