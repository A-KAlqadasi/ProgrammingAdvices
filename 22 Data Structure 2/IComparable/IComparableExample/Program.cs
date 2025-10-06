using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
	public class Person : IComparable<Person>
	{
		public string Name { get; set; }
		public int Age { get; set; }

        public int CompareTo(Person other)
		{
			if(other ==null ) return 1;

			return this.Age.CompareTo(other.Age);
		}

		public override string ToString()
		{
			return $"Name: {this.Name}, Age: {this.Age}";
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>
{
				new Person { Name = "John", Age = 30 },
				new Person { Name = "Jane", Age = 25 },
				new Person { Name = "Doe", Age = 28 },
			};

			people.Sort();

			foreach (Person person in people) 
			{
                Console.WriteLine(person);
            }

			Console.ReadKey();
		}
	}
}
