using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckExistence
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> fruits = new HashSet<string>()
			{
				"Apple","Banana","Orange"
			};

			if(fruits.Contains("Apple"))
			{
				Console.WriteLine("Apple in the hash set");
			}
			else
			{
				Console.WriteLine("Apple is not in the hash set");
			}
			if (fruits.Contains("Cherry"))
			{
				Console.WriteLine("Cherry in the hash set");
			}
			else
			{
				Console.WriteLine("Cherry is not in the hash set");
			}

			Console.ReadKey();
		}
	}
}
