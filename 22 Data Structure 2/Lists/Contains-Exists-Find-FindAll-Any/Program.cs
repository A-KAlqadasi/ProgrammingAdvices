using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Exists_Find_FindAll_Any
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 44, 22, 55, 666, 9, -6, 345, 11, -3, 3 };

			Console.WriteLine("list contains 9: "+ numbers.Contains(9));

			Console.WriteLine("list contains negative numbers: " + numbers.Exists(n=> n < 0));

			Console.WriteLine("Find first negative number: " + numbers.Find(n=>n<0));
			
			Console.WriteLine("Find all negative number: " + string.Join(", ",  numbers.FindAll(n => n < 0)));
			
			Console.WriteLine("Is any negative number exists: " +  numbers.Any(n => n < 0));



			Console.ReadKey();
		}
	}
}
