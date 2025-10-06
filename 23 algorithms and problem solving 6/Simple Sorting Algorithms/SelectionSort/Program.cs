using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
	class SelectionSortExample
	{
		static void SelectionSortAsc(int[] arr)
		{
			int n = arr.Length;

			// One by one move boundary of unsorted subarray
			for (int i = 0; i < n - 1; i++)
			{
				// Find the minimum element in unsorted array
				int minIndex = i;

				for (int j = i + 1; j < n; j++)
					if (arr[j] < arr[minIndex])
						minIndex = j;

				// Swap the found minimum element with the first element
				int temp = arr[minIndex];
				arr[minIndex] = arr[i];
				arr[i] = temp;
			}
		}

		static void SelectionSortDesc(int[] arr)
		{
			int n = arr.Length;

			// One by one move boundary of unsorted subarray
			for (int i = 0; i < n - 1; i++)
			{
				// Find the Maximum element in unsorted array
				int maxIndex = i;
				for (int j = i + 1; j < n; j++)
					if (arr[j] > arr[maxIndex])
						maxIndex = j;

				// Swap the found minimum element with the first element
				int temp = arr[maxIndex];
				arr[maxIndex] = arr[i];
				arr[i] = temp;
			}
		}

		static void SelectionSortAsc2(int[]arr)
		{
			int n = arr.Length;
			for (int i = 0; i < n - 1; i++)
			{
				int minIndex = i;

				for (int j = i+1; j < n; j++)
				{

					if (arr[j] < arr[minIndex])
						minIndex = j;
				}

				int temp = arr[i];
				arr[i] = arr[minIndex];
				arr[minIndex] = temp;

			}
		}

		static void SelectionSortDesc2(int[] arr)
		{
			int n = arr.Length;
			for (int i = 0; i < n - 1; i++)
			{
				int maxIndex = i;
				for (int j = i + 1; j < n ; j++)
				{
					if (arr[j] > arr[maxIndex])
						maxIndex = j;
				}

				int temp = arr[maxIndex];
				arr[maxIndex] = arr[i];
				arr[i] = temp;

			}
		}

		// Driver code
		static void Main(string[] args)
		{
			int[] arr = { 64, 34, 25, 12, 22, 11, 90 };


			Console.WriteLine("Original array:");
			foreach (int value in arr)
			{
				Console.Write(value + " ");
			}
			Console.WriteLine();

			SelectionSortAsc2(arr);

			Console.WriteLine("\nSorted array ASC:");
			foreach (int value in arr)
			{
				Console.Write(value + " ");
			}

			//SelectionSortDesc2(arr);

			Console.WriteLine("\n\nSorted array Desc:");

			for (int i = arr.Length - 1; i > 0; i--)
			{
				Console.Write(arr[i] + "  ");
            }

			
			Console.ReadKey();

		}
	}
}
