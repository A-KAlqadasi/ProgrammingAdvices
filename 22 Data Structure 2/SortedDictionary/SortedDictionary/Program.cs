using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedDictionary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SortedDictionary<string,int> sortedDict = new SortedDictionary<string,int>();

			sortedDict.Add("Orange", 50);
			sortedDict.Add("Apple", 20);
			sortedDict.Add("Banana", 30);

            Console.WriteLine("Contents of the sortedDictionary:");

			foreach(var kvp  in sortedDict)
			{
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.WriteLine("\nAccessing values by keys:");
            Console.WriteLine($"Value of 'Apple': {sortedDict["Apple"]}");
			Console.WriteLine($"Value of 'Orange': {sortedDict["Orange"]}");

            Console.WriteLine("\nChecking if a key exists:");
            Console.WriteLine($"Contains 'Banana:' {sortedDict.ContainsKey("Banana")}");
			Console.WriteLine($"Contains 'Grape:' {sortedDict.ContainsKey("Grape")}");

			sortedDict.Remove("Banana");
            Console.WriteLine("\nContents of the SortedDictionary after removal:");
            foreach (var kvp in sortedDict)
			{
				Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
			}



			Console.ReadKey();
		}
	}
}
