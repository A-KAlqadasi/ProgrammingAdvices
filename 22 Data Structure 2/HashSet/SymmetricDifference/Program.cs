using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricDifference
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
			HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

			set1.SymmetricExceptWith(set2); // take the unique from each one

			foreach (int i in set1)
			{
				Console.WriteLine(i);
			}
			Console.ReadKey();
		}
	}
}
