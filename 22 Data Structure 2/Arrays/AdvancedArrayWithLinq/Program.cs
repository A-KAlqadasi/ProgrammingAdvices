using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedArrayWithLinq
{
	internal class Program
	{
		static void Main(string[] args)
		{

			var people = new[]
			{
				new {Name="Ali", Age =30},
				new {Name = "Mohammed", Age=25},
				new {Name = "Waleed", Age = 30},
				new {Name = "Abdulkareem", Age = 25},
				new {Name = "Yousef", Age = 30}
			};


			var groupPeopleByAge = people.GroupBy(p => p.Age)
				.Select(
					group => new
					{
						Age = group.Key,
						People = group.OrderBy(p => p.Name)
					});

			foreach (var group in groupPeopleByAge)
			{
                Console.WriteLine("\nGroup age: "+ group.Age);
				foreach(var person in group.People)
				{
					Console.WriteLine($" - {person.Name}");
				}
            }


			Console.ReadKey();
		}
	}
}
