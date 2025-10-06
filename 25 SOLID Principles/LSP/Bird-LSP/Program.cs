using System;

namespace Bird_LSP
{
	public class Bird
	{
		public virtual void Eat()
		{
			Console.WriteLine("Bird is eating");
		}

	}
	public class FlyingBird : Bird
	{
		public virtual void Fly()
		{
			Console.WriteLine("Bird is flying");
		}
	}

	public class Eagle : FlyingBird
	{
		public override void Eat()
		{
			Console.WriteLine("Eagle is eating");
		}

		public override void Fly()
		{
			Console.WriteLine("Eagle is flying");
		}

	}

	public class Ostrich : Bird
	{
		public override void Eat()
		{
			Console.WriteLine("Ostrich is eating");
		}

	}

	internal class Program
	{
		static void Main(string[] args)
		{
			FlyingBird eagle = new Eagle();
			eagle.Eat();
			eagle.Fly();

			Bird ostrich = new Ostrich();

			ostrich.Eat();

			Console.ReadKey();
		}
	}
}
