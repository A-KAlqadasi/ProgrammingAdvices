using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string , int> fruits = new Dictionary<string , int>();

			fruits.Add("Apple", 12);
			fruits.Add("Banana", 20);
			fruits.Add("Orange", 10);

			foreach(KeyValuePair<string,int> kvp in fruits)
			{
				Console.WriteLine($"{kvp.Key}, count= {kvp.Value}");
			}

			fruits.Remove("Banana");

			Console.WriteLine("Dictionary after removing banana");
			foreach (KeyValuePair<string, int> kvp in fruits)
			{
				Console.WriteLine($"{kvp.Key}, count= {kvp.Value}");
			}

			Console.ReadKey();
		}
	}
}
