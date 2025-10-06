using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
	internal class Program
	{
		public static int LinearSearch(int[]arr, int number)
		{
			for (int i = 0;i<arr.Length;i++)
			{
				if (arr[i]== number)
					return i;
			}
			return -1;
		}

		static void Main(string[] args)
		{
			int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
			int x = 222; // Element to be searched

            Console.WriteLine("\nArray elements:");
			foreach (int i in arr)
			{
                Console.Write(i + "  ");
            }

			int result = LinearSearch(arr, x);

			if(result == -1)
                Console.WriteLine($"\nElement {x} not found");
			else
                Console.WriteLine($"\nElement {x} found at index {result}");
            Console.ReadKey();

        }
	}
}
