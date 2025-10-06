using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
	public interface IPrinter
	{
		void Print(string content);
		void Scan();
		void Fax();
	}

	public class BasicPrinter : IPrinter
	{
		public void Print(string content)
		{
			Console.WriteLine(content);
		}
		public void Scan()
		{
            throw new NotImplementedException();
        }

		public void Fax()
		{
           throw new NotImplementedException ();
        }

	}

	public class AdvancedPrinter:IPrinter
	{
		public void Print(string content)
		{
			Console.WriteLine("Printing:"+content);
		}
		public void Scan()
		{
            Console.WriteLine("Scanning....");
        }

		public void Fax()
		{
            Console.WriteLine("Faxing...");
        }
	}


	internal class Program
	{
		static void Main(string[] args)
		{

			BasicPrinter printer = new BasicPrinter();
			printer.Print("My name is abdulkareem");
			printer.Scan();
			printer.Fax();

			AdvancedPrinter printer2 = new AdvancedPrinter();
			printer2.Print("My name is abdulkareem");
			printer2.Scan();
			printer2.Fax();


			Console.ReadKey();
		}
	}
}
