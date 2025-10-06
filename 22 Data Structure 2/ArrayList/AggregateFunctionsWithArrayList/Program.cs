using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateFunctionsWithArrayList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ArrayList arrayList = new ArrayList { 10, 5, 20, 15, 30 };

			var min = arrayList.Cast<int>().Min();
			var max = arrayList.Cast<int>().Max();
			var sum	= arrayList.Cast<int>().Sum();
			var average = arrayList.Cast<int>().Average();
			var count = arrayList.Cast<int>().Count();


			Console.WriteLine("\nArrayList Items: ");
			for (int i = 0; i < arrayList.Count; i++)
			{
				Console.Write(arrayList[i].ToString() + " ");
			}

			Console.WriteLine("\n\nMinimum value in the ArrayList: " + min);
			Console.WriteLine("Maximum value in the ArrayList: " + max);
			Console.WriteLine("Sum values in the ArrayList: " + sum);
			Console.WriteLine("Average values in the ArrayList: " + average);
			Console.WriteLine("Count Items in the ArrayList: " + count);

			arrayList.Sort();

			Console.WriteLine("\nArrayList Items after sorting: ");
			for (int i = 0; i < arrayList.Count; i++)
			{
				Console.Write(arrayList[i].ToString() + " ");
			}


			Console.ReadKey();
		}
	}
}
