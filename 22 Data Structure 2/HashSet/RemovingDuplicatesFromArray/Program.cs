using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingDuplicatesFromArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[] { 1, 2, 2, 3, 4, 4,5 };
			// using hashSet to remove duplicates from the array

			HashSet<int> uniqueNumbers = new HashSet<int>(numbers);


			foreach (int number in uniqueNumbers)
			{
				Console.WriteLine(number);
			}
			Console.ReadKey();
		}
	}
}
