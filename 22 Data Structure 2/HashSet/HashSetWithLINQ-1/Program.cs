using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetWithLINQ_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> numbers = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var evenNumbers = numbers.Where(n => n % 2 == 0);
			Console.WriteLine("Even Numbers");
			foreach (var n in evenNumbers)
			{
				Console.WriteLine(n);
			}

			var numbersGreaterThan5 = numbers.Where(n => n > 5);
			Console.WriteLine("Numbers greater than 5");
			foreach (var n in numbersGreaterThan5)
			{
				Console.WriteLine(n);
			}

			Console.ReadKey();
		}

	}
}
