using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
	internal class Program
	{
		public static int BinarySearch(int[] arr, int searchElement)
		{
			int start = 0, end = arr.Length-1;
			int trials = 0;
			while(start <= end)
			{
				int middle = start + (end - start) / 2;
				trials++;
                Console.WriteLine("Trials: " +trials);
                if (arr[middle] == searchElement)
					return middle;

				if (searchElement > arr[middle])
					start = middle + 1;
				else 
					end = middle - 1;
			}
			return -1;
		}
		static void Main(string[] args)
		{
			int[] arr = { 22, 25, 37, 41, 45, 46, 49, 51, 55, 58, 70, 80, 82, 90, 95 }; // Sorted array

			int x = 99; // Element to be searched

			Console.WriteLine("Sorted Array:");
			foreach (var item in arr)
				Console.Write(item + " ");
			Console.WriteLine();

			int result = BinarySearch(arr, x);

			if (result == -1)
				Console.WriteLine($"\nElement {x} not found");
			else
				Console.WriteLine($"\nElement {x} found at index {result}");
			
			Console.ReadKey();

		}
	}
}
