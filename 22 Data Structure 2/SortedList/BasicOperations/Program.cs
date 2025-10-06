using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var sortedList = new SortedList<string, int>();
			var dictionary = new Dictionary<string, int>();
			dictionary.Add("Tomato", 2);

			sortedList.Add("Banana", 4);
			sortedList.Add("Orange", 3);
			sortedList.Add("Apple", 2);

			Console.WriteLine("Sorted list elements");

			foreach(var kvp in sortedList)
			{
				Console.WriteLine($"Fruit: {kvp.Key}, Quantity: {kvp.Value}");
			}

			
			sortedList.Remove("Banana");
		//	sortedList.RemoveAt(0); // it can be deleted by index unlike dictionary 
			Console.WriteLine("Sorted list elements after deleting Banana");

			foreach (var kvp in sortedList)
			{
				Console.WriteLine($"Fruit: {kvp.Key}, Quantity: {kvp.Value}");
			}

			Console.ReadKey();
		}
	}
}
