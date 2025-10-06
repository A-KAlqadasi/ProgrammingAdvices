using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// Creating and populating a HashSet
			HashSet<string> fruits = new HashSet<string> { "Apple", "Banana", "Cherry" };

			Console.WriteLine("Hashset Item Count = " + fruits.Count.ToString());

			// Removing "Banana" from the HashSet
			fruits.Remove("Banana");

			Console.WriteLine("\nHashset Item Count after removing Banana = " + fruits.Count.ToString());
			// Displaying the remaining elements
			foreach (string fruit in fruits)
			{
				Console.WriteLine(fruit);
			}

			//this will remove all elements
			fruits.Clear();
			Console.WriteLine("\nHashset Item Count after clear = " + fruits.Count.ToString());

			Console.ReadKey();
		}
	}
}
