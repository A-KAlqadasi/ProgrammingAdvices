using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetWithLINQ_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Creating and populating a HashSet of strings
			HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona" };

			var namesStartWithC = names.Where(n => n.StartsWith("C"));

			Console.WriteLine("Names start with C");
			foreach(var name in namesStartWithC)
			{
				Console.WriteLine(name);
			}

			var namesWithNamesLongerThan4 = names.Where(n => n.Length > 4);
			Console.WriteLine("Names length greater than 4");

			foreach (var name in namesWithNamesLongerThan4)
			{
				Console.WriteLine(name); 
			}

			Console.ReadKey();
		}
	}
}
