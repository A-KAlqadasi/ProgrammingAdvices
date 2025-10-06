using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotring
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> {44, 22, 55, 666, 9, -6, 345, 11, 3, 3 };

			// Default sorting ascending
			numbers.Sort();
			Console.WriteLine("Sorted in Ascending Order: "+ string.Join(", ", numbers));

			numbers.Reverse();
			Console.WriteLine("Sorted in Descending Order: " + string.Join(", ", numbers));

			// Sorting with LINQ 

			Console.WriteLine("Sorted Ascending With LINQ: " + string.Join(", ", numbers.OrderBy(n=>n)));
			Console.WriteLine("Sorted Descending With LINQ: " + string.Join(", ", numbers.OrderByDescending(n => n)));



			Console.ReadKey();
		}
	}
}
