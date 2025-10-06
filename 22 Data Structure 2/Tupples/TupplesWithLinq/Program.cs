using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupplesWithLinq
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<(int Id, string name, int age)> people = new List<(int Id, string name, int age)>() 
			{
				(1, "Alice", 30),
				(2, "Bob", 25),
				(3, "Charlie", 35),
				(4, "Diana", 28)
			};

			var filterPeople = people.Where(p => p.age > 30);

			foreach( var person in filterPeople)
			{
                Console.WriteLine($"Id: {person.Id}, Name: {person.name}, Age: {person.age}");
            }

            var ageTotal = people.Average(p=> p.age);

            Console.WriteLine("Age average: "+ ageTotal);

            Console.ReadKey();
		}
	}
}
