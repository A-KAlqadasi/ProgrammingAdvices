using System;
using System.Collections.Generic;

namespace RemoveElements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			Console.WriteLine($"Actual list: {string.Join(",", numbers)}");

			// removing an item by value
			numbers.Remove(5);
			Console.WriteLine($"After removing 5: {string.Join(",",numbers)}");

			numbers.RemoveAt(0);
			Console.WriteLine($"After removing last element: {string.Join(",", numbers)}");

			numbers.RemoveRange(2, 2);
			Console.WriteLine($"After removing 2 elements from index 2: {string.Join(",", numbers)}");

			// using lambda expression 
			numbers.RemoveAll(x => x % 2 == 0);
			Console.WriteLine($"After removing all even numbers: {string.Join(",", numbers)}");

			
			numbers.Clear();
			Console.WriteLine("After clearing the list , count: "+ numbers.Count);

			Console.ReadKey();
		}
	}
}
