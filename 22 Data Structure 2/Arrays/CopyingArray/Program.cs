using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CopyingArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] orginal = { 1, 2, 3, 4 };
			
			int[] copy =new int[orginal.Length];

			Array.Copy(orginal, copy, orginal.Length);

			// Displaying the copied array
			Console.WriteLine("Copied Array:");
			foreach (int element in copy)
			{
				Console.WriteLine(element);
			}


			Console.ReadKey();
		}
	}
}
