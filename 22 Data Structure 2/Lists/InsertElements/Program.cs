using System;
using System.Collections.Generic;

namespace InsertElements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> {1,2, 3, 4, 5, 6, 7, 8, 9, 10};

			Console.WriteLine("List capacity:"+ numbers.Capacity);
			Console.WriteLine("List Count: "+ numbers.Count);
			// adding an element at the end
			numbers.Add(11);
			Console.WriteLine($"After adding 11: {string.Join(",",numbers)}");

			// inserting an element at specific index
			numbers.Insert(0, 0);
			Console.WriteLine($"After inserting 0 at the beginning: {string.Join(",", numbers)}");

			// inserting an element at end using index
			numbers.Insert(numbers.Count, 0);
			Console.WriteLine($"After inserting 0 at the end: {string.Join(",", numbers)}");


			// Inserting multiple elements 
			numbers.InsertRange(5, new List<int> { 55, 56 });
			Console.WriteLine($"After inserting 55 and 56 at index 5: {string.Join(",", numbers)}");



			Console.ReadKey();
		}
	}
}
