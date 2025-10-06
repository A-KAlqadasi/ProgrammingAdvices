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
			SortedSet<int> sortedSet = new SortedSet<int>() { 1, 2, 3, 4, 5 };

			var filterSortedSet = sortedSet.Where(x => x > 2);

			foreach (var filter in filterSortedSet)
			{
                Console.Write(filter + " ");
            }

			var minElement = sortedSet.Min();
			var maxElement = sortedSet.Max();

			Console.WriteLine($"Minimum element in sorted list is : {minElement}");
			Console.WriteLine($"Maximum element in sorted list is : {maxElement}");

			var sum = sortedSet.Sum();
			Console.WriteLine("Sum of all elements: " + sum);

			// Sorting the set in descending order
			var descendingSet = sortedSet.OrderByDescending(x => x);
			Console.WriteLine("Descending Sorted Set:");
			foreach (var item in descendingSet)
			{
				Console.Write(item + " ");
			}

			Console.ReadKey();
        }
	}
}
