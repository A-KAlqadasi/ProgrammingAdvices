using System;
using System.Data;
using System.Linq;

namespace _15_DataTableFilters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable();

            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(Double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            EmployeesDataTable.Rows.Add(1, "Abdulkareem", "Yemen", 5000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Mohammed", "Jordan", 3000, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "Waleed", "Sariya", 4000, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "Ahmed", "Egypt", 750.7, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Lina", "Yemen", 800.5, DateTime.Now);

            Console.WriteLine("\n\nEmployees List:\n");

            foreach (DataRow row in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}\tName: {row["Name"]}" +
                    $"\tCountry: {row["Country"]}\tSalary: {row["Salary"]}\tDate: {row["Date"]}");
            }


            int EmployeesCount = EmployeesDataTable.Rows.Count;
            double TotalSalary = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", string.Empty));
            double AverageSalary = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", string.Empty));
            double MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("MIN(Salary)", string.Empty));
            double MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", string.Empty));

            Console.WriteLine("\nCount of Employees = " + EmployeesCount);
            Console.WriteLine("\nTotal Employees Salary = " + TotalSalary);
            Console.WriteLine("\nAverage of Salaries = " + AverageSalary);
            Console.WriteLine("\nMin Salry = " + MinSalary);
            Console.WriteLine("\nMax Salry = " + MaxSalary);

            //filter by Yemen

            Console.WriteLine("\n\nFilter \"Yemen\" Employees\n");

            int resultCount = 0;
            DataRow[] resultData = EmployeesDataTable.Select("Country='Yemen'");

            foreach(DataRow row in resultData)
            {
                Console.WriteLine($"ID: {row["ID"]}\tName: {row["Name"]}" +
                       $"\tCountry: {row["Country"]}\tSalary: {row["Salary"]}\tDate: {row["Date"]}");
            }

            resultCount = resultData.Count();
            TotalSalary = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "Country='Yemen'"));
            AverageSalary = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "Country='Yemen'"));
            MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("MIN(Salary)", "Country='Yemen'"));
            MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "Country='Yemen'"));
            
            Console.WriteLine("\nCount of Employees = " + resultCount);
            Console.WriteLine("\nTotal Employees Salary = " + TotalSalary);
            Console.WriteLine("\nAverage of Salaries = " + AverageSalary);
            Console.WriteLine("\nMin Salry = " + MinSalary);
            Console.WriteLine("\nMax Salry = " + MaxSalary);

            //Filter by Jordan or Yemen
            Console.WriteLine("\n\nFilter \"Yemen\" or \"Jordan\" Employees\n");

             resultCount = 0;
             resultData = EmployeesDataTable.Select($"Country LIKE 'Ye'");

            foreach (DataRow row in resultData)
            {
                Console.WriteLine($"ID: {row["ID"]}\tName: {row["Name"]}" +
                       $"\tCountry: {row["Country"]}\tSalary: {row["Salary"]}\tDate: {row["Date"]}");
            }

            //resultCount = resultData.Count();
            //TotalSalary = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "Country in ('Yemen','Jordan')"));
            //AverageSalary = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "Country in ('Yemen','Jordan')"));
            //MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("MIN(Salary)", "Country in ('Yemen','Jordan')"));
            //MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "Country in ('Yemen','Jordan')"));

            //Console.WriteLine("\nCount of Employees = " + resultCount);
            //Console.WriteLine("\nTotal Employees Salary = " + TotalSalary);
            //Console.WriteLine("\nAverage of Salaries = " + AverageSalary);
            //Console.WriteLine("\nMin Salry = " + MinSalary);
            //Console.WriteLine("\nMax Salry = " + MaxSalary);

            ////Filter by ID=1 

            //Console.WriteLine("\n\nFilter Employee with ID=1\n");

            //resultCount = 0;
            //resultData = EmployeesDataTable.Select("ID=1");

            //foreach (DataRow row in resultData)
            //{
            //    Console.WriteLine($"ID: {row["ID"]}\tName: {row["Name"]}" +
            //           $"\tCountry: {row["Country"]}\tSalary: {row["Salary"]}\tDate: {row["Date"]}");
            //}

            //resultCount = resultData.Count();
            //TotalSalary = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "ID=1"));
            //AverageSalary = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "ID=1"));
            //MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("MIN(Salary)", "ID=1"));
            //MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "ID=1"));

            //Console.WriteLine("\nCount of Employees = " + resultCount);
            //Console.WriteLine("\nTotal Employees Salary = " + TotalSalary);
            //Console.WriteLine("\nAverage of Salaries = " + AverageSalary);
            //Console.WriteLine("\nMin Salry = " + MinSalary);
            //Console.WriteLine("\nMax Salry = " + MaxSalary);


            Console.ReadKey();

        }
    }
}
