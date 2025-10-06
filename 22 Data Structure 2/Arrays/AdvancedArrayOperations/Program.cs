using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedArrayOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Initializing an array
			int[] numbers = { 5, 3, 1, 4, 2 };

			Array.Sort(numbers);

            Console.WriteLine("Sorted elements:");
            Console.WriteLine(string.Join(", ", numbers));

			int index = Array.IndexOf(numbers, 4);

            Console.WriteLine("\nIndex of element 4: "+ index);


            Console.ReadKey();
		}
	}
}
