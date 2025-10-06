using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListWithLINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SortedList<int, string> sortedList = new SortedList<int, string>
			{
				{1, "One" },
				{3, "Three" },
				{4, "Four" },
				{2, "Two" }
			};

			// using query expression syntax to make LINQ on collections
			var queryExpressionSyntax = from kvp in sortedList
										where kvp.Key > 1
										select kvp;
			Console.WriteLine("\nUsing query expression syntax");

			foreach ( var kvp in queryExpressionSyntax )
			{
				Console.WriteLine($"{kvp.Key}, {kvp.Value}");
			}

			var methodSyntax = sortedList.Where(kvp => kvp.Key > 1);
			Console.WriteLine("\nUsing method syntax");
			foreach (var kvp in methodSyntax)
			{
				Console.WriteLine($"{kvp.Key}, {kvp.Value}");
			}



			Console.ReadKey();
		}
	}
}
