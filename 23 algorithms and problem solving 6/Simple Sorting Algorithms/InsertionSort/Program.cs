using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
	internal class Program
	{

		static void InsertionSort(int[] arr)
		{
			int n = arr.Length;
			for (int i = 1; i < n; ++i)
			{
				int key = arr[i];
				int j = i - 1;

				// Move elements of arr[0..i-1], that are greater than key,
				// to one position ahead of their current position
				while (j >= 0 && arr[j] > key)
				{
					arr[j + 1] = arr[j];
					j = j - 1;
				}
				arr[j + 1] = key;
			}
		}

		static void Main(string[] args)
		{
			int[] arr = { 64, 34, 25, 12, 22, 11, 90 };


			Console.WriteLine("Original array:");
			foreach (int value in arr)
			{
				Console.Write(value + " ");
			}
			Console.WriteLine();

			InsertionSort(arr);

			Console.WriteLine("Insertion sorted array:");
			foreach (int value in arr)
			{
				Console.Write(value + " ");
			}
			Console.WriteLine();

			Console.ReadKey();
		}



	}
}
