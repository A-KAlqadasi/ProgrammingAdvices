using System;
using System.Collections.Generic;
using System.Linq;


namespace FilteringDataUsingLINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			Console.WriteLine($"Print all even numbers: {string.Join(",", numbers.Where(x => x % 2 == 0))}");
			Console.WriteLine($"Print all odd numbers: {string.Join(",", numbers.Where(x => x % 2 != 0))}");
			Console.WriteLine($"Print all numbers greater than 5: {string.Join(",", numbers.Where(x => x > 5))}");
			Console.WriteLine($"Print every second number: {string.Join(",", numbers.Where((x,index) => index % 2  == 1))}");
			Console.WriteLine($"Print all number between 3 and 8: {string.Join(",",numbers.Where(x=> x > 3 && x < 8))}");

			List<string> names = new List<string>() { "Ali", "Ahmed", "Abdulkareem", "Ali", "Yousef" };

			Console.WriteLine($"Print name : {string.Join(",",names.Where(name => name == "Ali"))}");


			Console.ReadKey();
		}
	}
}
