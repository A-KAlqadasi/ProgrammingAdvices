using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_ISP
{
	
	public interface IPrint
	{
		void Print(string content);
	}

	public interface IScan
	{
		void Scan();
	}

	public interface IFax
	{
		void Fax();
	}

	public class BasicPrinter : IPrint
	{
		public void Print(string content)
		{
			Console.WriteLine("Printing: "+content);
		}
		

	}

	public class AdvancedPrinter : IPrint,IFax,IScan
	{
		public void Print(string content)
		{
			Console.WriteLine("Printing:" + content);
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
			

			AdvancedPrinter printer2 = new AdvancedPrinter();
			printer2.Print("My name is abdulkareem");
			printer2.Scan();
			printer2.Fax();


			Console.ReadKey();
		}
	}
}
