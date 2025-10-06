using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SortedSet<int> sortedSet = new SortedSet<int>();

			sortedSet.Add(3);
			sortedSet.Add(2);
			sortedSet.Add(5);
			sortedSet.Add(4);
			sortedSet.Add(1);
			sortedSet.Add(1);

            Console.WriteLine("\nSortedSet elements:");
            foreach (int i in sortedSet)
			{
                Console.WriteLine(i);
            }

			if(sortedSet.Contains(3))
                Console.WriteLine("Sorted set contains 3");
			else
                Console.WriteLine("Sorted set dose not contain 3");

			sortedSet.Remove(3);
            Console.WriteLine("Sorted list elements after removing 3");
            Console.WriteLine(string.Join(", ", sortedSet));

			

            Console.ReadKey();
		}
	}
}
