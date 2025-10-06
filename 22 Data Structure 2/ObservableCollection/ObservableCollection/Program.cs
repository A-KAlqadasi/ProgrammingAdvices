using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ObservableCollection<string> names = new ObservableCollection<string>();

			names.Add("Ali");
			names.Add("Ahmed");
			names.Add("Mohammed");
			names.Add("Waleed");

			foreach(string name in names)
			{
                Console.WriteLine(name);
            }


			Console.ReadKey();
		}
	}
}
