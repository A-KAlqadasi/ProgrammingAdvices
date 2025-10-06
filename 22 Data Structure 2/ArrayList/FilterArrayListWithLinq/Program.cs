using System;
using System.Collections;
using System.Linq;

namespace FilterArrayListWithLinq
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

			//we use cast here to convert it to int first then we apply the filter.
			var filteredArrayList = arrayList.Cast<int>().Where(n=> n%2 ==0);

			foreach(var item in filteredArrayList)
			{
                Console.WriteLine(item);
            }

			Console.ReadKey();
		}
	}
}
