using System;
using System.Collections.Generic;

namespace Example1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>();

			numbers.Add(1);
			numbers.Add(2);
			numbers.Add(3);
			numbers.Add(4);
			numbers.Add(5);

			Console.WriteLine($"Count elements in list: {numbers.Count}");

			Console.WriteLine("All elements in list:");
			for (int i = 0; i < numbers.Count; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			Console.WriteLine($"Changing element 2 in the list");
			numbers[1] = 500;
			Console.WriteLine(numbers[1]);

			Console.ReadKey();
		}
	}
}
