using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryWithLINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> fruits = new Dictionary<string, int>()
			{
				{"Apple",5 },
				{"Orange",2 },
				{"Banana",7 }
			};

			var fruitInfo = fruits.Select(kvp => new { kvp.Key, kvp.Value });

			Console.WriteLine("Transformed items");
			foreach (var kvp in fruitInfo)
			{
				Console.WriteLine($"Fruit = {kvp.Key}, Quantity= {kvp.Value}");
			}

			var filteredFruits = fruits.Where(kvp=>kvp.Value>3);

			Console.WriteLine("Filtered items where quantity > 3");
			foreach (var kvp in filteredFruits)
			{
				Console.WriteLine($"Fruit = {kvp.Key}, Quantity= {kvp.Value}");
			}

			var sortedByValueAscending = fruits.OrderBy(kvp=>kvp.Value);

			Console.WriteLine("Order ascending items by value");
			foreach (var kvp in sortedByValueAscending)
			{
				Console.WriteLine($"Fruit = {kvp.Key}, Quantity= {kvp.Value}");
			}
			
			var sortedByValueDescending = fruits.OrderByDescending(kvp=>kvp.Value);
			Console.WriteLine("Order descending items by value");
			foreach (var kvp in sortedByValueDescending)
			{
				Console.WriteLine($"Fruit = {kvp.Key}, Quantity= {kvp.Value}");
			}

			int totalQuantity = fruits.Sum(kvp=>kvp.Value);
			Console.WriteLine("Total Quantity: " + totalQuantity);

			Console.ReadKey();
		}
	}
}
