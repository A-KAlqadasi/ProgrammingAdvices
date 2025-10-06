using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeWithLinq
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Person[] people = new Person[5] 
			{ 
				new Person("Ali",20,"Yemen"),
				new Person("Ahmed",25,"Jordan"),
				new Person("Mohammed",20,"Yemen"),
				new Person("Saleh",25,"Jordan"),
				new Person("Yaser",30,"Iraq")
			};

			
			var peopleFromYemen = people.GroupBy(g => g.Country).
				Select(group => new
				{
					Country = group.Key,
					People = group
				});

            Console.WriteLine("\nGroup by people country");
            foreach (var group in peopleFromYemen)
			{
                Console.WriteLine("Country: "+ group.Country);
				foreach(var person in group.People)
				{
                    Console.WriteLine(person);
                }	
            }

			var peopleAge = people.GroupBy(g => g.Age).Select(group => new
			{
				Age = group.Key,
				People = group.OrderBy(g=>g.Name)
			}).Where(g=>g.Age == 20);

            Console.WriteLine("\nPeople age 20");

            foreach (var group in peopleAge)
			{
                Console.WriteLine("Age: "+ group.Age);
				foreach(var person in group.People)
				{
					Console.WriteLine(person);
				}
            }

			Console.ReadKey();
		}
	}

	public class Person
	{
		public string Name { get; set; }

		public int Age { get; set; }
		public string Country { get; set; }
        public Person(string name, int age, string country)
        {
            this.Name = name;
			this.Age = age;
			this.Country = country;
        }
		public override string ToString()
		{
			return $"Name: {Name}, Age: {Age}, Country: {Country}";
		}
	}

}
