using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
			SortedSet<int> set2 = new SortedSet<int>() { 3, 4, 5, 6, 7 };

			// Union
			SortedSet<int> unionSet = new SortedSet<int>(set1);
			unionSet.UnionWith(set2);
            Console.WriteLine($"Union set : {string.Join(", ", unionSet)}");

			// Intersection
			SortedSet<int> intersectSet = new SortedSet<int>(set1);
			intersectSet.IntersectWith(set2);
			Console.WriteLine($"Intersect set : {string.Join(", ", intersectSet)}");

			// Difference
			SortedSet<int> diffSet = new SortedSet<int>(set1);
			diffSet.ExceptWith(set2);
			Console.WriteLine($"Difference set : {string.Join(", ", diffSet)}");

            // Subset and Superset

            Console.WriteLine("\nSupperset");
            if (set1.IsSupersetOf(set2))
                Console.WriteLine("set1 is supperset of set2");
			 else
                Console.WriteLine("set1 is not supperset of set2");
            
            Console.WriteLine("\nSubset");

			if (set1.IsSubsetOf(set2))
				Console.WriteLine("set1 is subset of set2");
			else
				Console.WriteLine("set1 is not subset of set2");

			Console.ReadKey();
		}
	}
}
