using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfCustomObjects
{
	public class Person
	{
		public Person(int age, string name)
		{
			Age = age;
			Name = name;
		}

		public int Age { get; set; }
		public string Name { get; set; }

		public override string ToString()
		{
			return $"Name = {this.Name}, Age = {this.Age}";
		}

	}
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>
			{
				new Person(27, "Alice"),
				new Person(24, "Ali"),
				new Person(25, "Mohammed"),
				new Person(29, "Ahmed"),
				new Person(30, "Waleed"),
				new Person(40, "Ismail"),
				new Person(32, "Ahd"),

			};

			Console.WriteLine("All people");
			
			foreach(Person person in people)
			{
				Console.WriteLine(person);
			}

			Person personAli = people.Find(p => p.Name == "Ali");

			if(personAli != null)
			{
				Console.WriteLine("Found person Name Ali: " + personAli);
			}

			// FirstOrDefault from the LINQ it is the same as List.Find 

			Person personMohammed = people.FirstOrDefault(p => p.Name == "Mohammed");

			if(personMohammed != null )
			{
				personMohammed.Age = 31;
				Console.WriteLine("Updating Mohammed Age: " + personMohammed);
			}

			List<Person> peopleOver30 = people.FindAll(p => p.Age > 30);
			Console.WriteLine("All people Over 30:");
			foreach( Person person in peopleOver30)
			{
				Console.WriteLine(person);
			}

			Console.WriteLine("List contains person name Waleed: " + people.Exists(p=>p.Name == "Waleed"));

			Console.WriteLine("Exists person over 40: " + people.Any(p=> p.Age > 40));


			Console.WriteLine("Remove people under 30 age: ");
			people.RemoveAll(p => p.Age < 30);

			Console.WriteLine("List people after all affects");

			foreach (Person person in people)
			{
				Console.WriteLine(person);
			}
			Console.ReadKey();

		}
	}
}
