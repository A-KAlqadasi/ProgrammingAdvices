using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Declaring an integer array
			int[] numbers = new int[5];


			// Initializing an array with values
			string[] names = { "Alice", "Bob", "Charlie" };


			// Display the names
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}
			Console.ReadKey();
		}
	}
}
