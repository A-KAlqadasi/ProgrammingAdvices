using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopThroughList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			Console.WriteLine("looping through list using the for statement ");
			for (int i = 0; i < numbers.Count; i++)
			{
				Console.Write(numbers[i] + "  ");
			}

			Console.WriteLine("\nlooping through list using foreach statement");
			foreach(int i in numbers)
			{
				Console.Write(i + "  ");
			}

			Console.WriteLine("\nlooping through list using List.ForEach statement");

			numbers.ForEach(x => Console.Write(x+"  "));

			Console.ReadKey();
		}

		public static void Print(int num)
		{
			if(num % 2== 0)
				Console.WriteLine(num);
		}

	}
}
