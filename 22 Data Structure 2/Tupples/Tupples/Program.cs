using System;
using System.Collections.Generic;


namespace Tupples
{
	internal class Program
	{
		static void Main(string[] args)
		{
			(int id, string name, double feet) person = (1, "Ali", 5.5);

			Console.WriteLine("Id: " + person.id);
			Console.WriteLine("Name: " + person.name);
			Console.WriteLine("Feet: "+ person.feet);

			var value = TubleMethod();

            Console.WriteLine("\nId: "+ value.Item1);
			Console.WriteLine("Name: " + value.Item2);


			Console.ReadKey();
		}
		static public (int, string) TubleMethod()
		{
			return (2, "Mohammed");
		}
	}
}
