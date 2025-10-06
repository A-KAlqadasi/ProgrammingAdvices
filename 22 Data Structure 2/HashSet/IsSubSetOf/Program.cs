using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSubSetOf
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> set1 = new HashSet<int> { 1, 2 };
			HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5};

			Console.WriteLine("Set1 is subset of Set2: " + set1.IsSubsetOf(set2));
			Console.WriteLine("Set2 is subset of Set1: " + set2.IsSubsetOf(set1));


			Console.ReadKey();
		}
	}
}
