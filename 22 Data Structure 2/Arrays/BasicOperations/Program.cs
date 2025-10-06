using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Initializing an array
			int[] numbers = { 1, 2, 3, 4, 5 };


			// Accessing and modifying elements
			numbers[0] = 10;


			// Using for loop for iteration
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine("Element at index " + i + ": " + numbers[i]);
			}
			Console.ReadKey();
		}
	}
}
