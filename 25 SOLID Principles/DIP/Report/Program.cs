using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report
{
	public class PdfReportGenerator
	{
		public void Generate()
		{
            Console.WriteLine("\npdf generator");
        }

	}
	public class ReportGenerator
	{
		PdfReportGenerator _pdfReportGenerator;

        public ReportGenerator()
        {
			_pdfReportGenerator = new PdfReportGenerator();
        }
		public void GenerateReport()
		{
			_pdfReportGenerator.Generate();
		}

    }
	internal class Program
	{
		static void Main(string[] args)
		{
			ReportGenerator report = new ReportGenerator();
			report.GenerateReport();

			Console.ReadKey();
		}
	}
}
