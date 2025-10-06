using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSuperSetOf
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
			HashSet<int> set2 = new HashSet<int> { 3, 5 };

			Console.WriteLine("Is set1 superset of set2: " + set1.IsSupersetOf(set2));
			
			Console.ReadKey();
		}
	}
}
