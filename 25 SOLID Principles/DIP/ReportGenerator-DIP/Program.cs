using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator_DIP
{

	public interface IReportGenerator
	{
		 void Generate();
	}

	public class PdfReportGenerator:IReportGenerator
	{
		public void Generate()
		{
			Console.WriteLine("pdf report generated");
		}

	}

	public class ExcelReportGenerator : IReportGenerator
	{
		public void Generate()
		{
			Console.WriteLine("Excel report generated");
		}

	}

	public class WordReportGenerator : IReportGenerator
	{
		public void Generate()
		{
			Console.WriteLine("Word report generated");
		}

	}

	public class CrystalReportGenerator : IReportGenerator
	{
		public void Generate()
		{
			Console.WriteLine("Crystal report generated");
		}

	}

	public class ReportGenerator
	{
		IReportGenerator _ReportGenerator;

		public ReportGenerator(IReportGenerator reportGenerator)
		{
			_ReportGenerator = reportGenerator;
		}
		public void GenerateReport()
		{
			_ReportGenerator.Generate();
		}

	}

	internal class Program
	{
		static void Main(string[] args)
		{

			ReportGenerator report = new ReportGenerator(new PdfReportGenerator());
			report.GenerateReport();

			report = new ReportGenerator(new ExcelReportGenerator());
			report.GenerateReport();

			report = new ReportGenerator(new WordReportGenerator());
			report.GenerateReport();

			report = new ReportGenerator(new CrystalReportGenerator());
			report.GenerateReport();


			Console.ReadKey();
		}
	}
}
