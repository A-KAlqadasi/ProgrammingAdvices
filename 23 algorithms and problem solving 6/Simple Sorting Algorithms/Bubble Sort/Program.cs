using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

			Console.WriteLine("Original array:");
			foreach (int i in arr)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();

			BubbleSort(arr);

			
			Console.WriteLine("\nSorted array:");
			foreach (int i in arr)
			{
				Console.Write(i + " ");
			}
			Console.ReadKey();
		}

		public static void BubbleSort(int[] arr)
		{
			int n = arr.Length;
			for(int i = 0; i< n -1;i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (arr[j] > arr[j+1])
					{
						int temp = arr[j];
						arr[j] = arr[j+1];
						arr[j+1] = temp;
					}
				}
			}
		}
		static void BubbleSortH(int[] arr)
		{
			int n = arr.Length;
			// 6
			for (int i = 0; i < n - 1; i++)
				for (int j = 0; j < n - i - 1; j++)
					if (arr[j] > arr[j + 1])
					{
						// Swap temp and arr[i]
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
		}


	}
}
