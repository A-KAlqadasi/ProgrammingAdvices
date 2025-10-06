using System;
using System.Collections.Generic;

namespace Add
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> fruits = new HashSet<string>();

			fruits.Add("Apple");
			fruits.Add("Banana");
			fruits.Add("Orange");

			// here we try to duplicate Apple, it will not be added
			fruits.Add("Apple");
			fruits.Add("Apple");
			
			foreach(string s in fruits)
			{
				Console.WriteLine(s);
			}

			Console.ReadKey();
		}
	}
}
