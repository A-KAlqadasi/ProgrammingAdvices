using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLINQWithGrouping
{
	internal class Program
	{

		static void Main(string[] args)
		{
			// Initialize a SortedList of int keys and string values with fruit names
			SortedList<int, string> sortedList = new SortedList<int, string>()
			{
				{ 1, "Apple" },
				{ 2, "Banana" },
				{ 3, "Cherry" },
				{ 4, "Date" },
				{ 5, "Grape" },
				{ 6, "Fig" },
				{ 7, "Elderberry" }
			};

			SortedList<int,List<string>> var = new SortedList<int, List<string>>();

			var groups = sortedList.GroupBy(x => x.Value.Length);

			foreach (var group in groups)
			{
				Console.WriteLine($"Length: {group.Key} : {string.Join(", ", group.Select(kvp=>kvp.Value))} ");
			}

			Console.ReadKey();
		}
	}
}
