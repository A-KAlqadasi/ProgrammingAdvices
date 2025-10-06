using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird
{
	public class Bird
	{
		public virtual void Eat()
		{
            Console.WriteLine("Bird is eating");
        }
		public virtual void Fly()
		{
            Console.WriteLine("Bird is flying");
        }
	}

	public class Eagle : Bird
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

	public class Ostirch : Bird
	{
		public override void Eat()
		{
            Console.WriteLine("Ortirch is eating");
        }

		public override void Fly()
		{
			throw new NotSupportedException("Ortiches can't fly");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Bird eagle = new Eagle();
			eagle.Eat();
			eagle.Fly();

			Bird ortich = new Ostirch();

			ortich.Eat();
			ortich.Fly();
			Console.ReadKey();
		}
	}
}
