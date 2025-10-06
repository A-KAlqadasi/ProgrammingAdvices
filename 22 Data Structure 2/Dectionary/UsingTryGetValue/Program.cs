using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTryGetValue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> fruits = new Dictionary<string, int>()
			{
				{"Apple",12 },
				{"Banana",20 }
			};

			if(fruits.TryGetValue("Apple", out int AppleQty))
			{
				Console.WriteLine("Apple quantity : " + AppleQty);
			}
			else
			{
				Console.WriteLine("Apple is not found in the fruit basket");
			}

			if(fruits.TryGetValue("Orange", out int OrangeQty))
			{
				Console.WriteLine("Orange Quantity: "+ OrangeQty);
			}
			else
				Console.WriteLine("Orange is not found in the basket");

			Console.ReadKey();

		}
	}
}
