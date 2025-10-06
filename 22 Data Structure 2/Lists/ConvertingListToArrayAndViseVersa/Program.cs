using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingListToArrayAndViseVersa
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// converting list to array
			int[] numbersArray = numbers.ToArray();

			Console.WriteLine("Print array: "+ string.Join(", ",numbersArray));

			List<int> numbersList2 = new List<int>(numbersArray);
			Console.WriteLine("Print list: " + string.Join(", ", numbersList2));



			Console.ReadKey();
		}
	}
}
