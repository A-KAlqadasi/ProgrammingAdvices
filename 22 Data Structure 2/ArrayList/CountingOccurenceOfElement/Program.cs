using System;
using System.Collections;
using System.Linq;

namespace CountingOccurenceOfElement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ArrayList arrayList = new ArrayList { 10, 5, 20, 10, 10 };

			int tragetElement = 10;
			var count = arrayList.Cast<int>().Count(num=> num == tragetElement);

            Console.WriteLine("10 repeated : "+ count);

            Console.ReadKey();
		}
	}
}
