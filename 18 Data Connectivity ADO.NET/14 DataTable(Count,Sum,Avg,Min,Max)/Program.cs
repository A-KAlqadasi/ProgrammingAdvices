using System;
using System.Data;
using System.Linq;



namespace DataTablesAggregateFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable();

            EmployeesDataTable.Columns.Add("ID",typeof(int));
            EmployeesDataTable.Columns.Add("Name",typeof(string));
            EmployeesDataTable.Columns.Add("Country",typeof(string));   
            EmployeesDataTable.Columns.Add("Salary",typeof(Double));
            EmployeesDataTable.Columns.Add("Date",typeof(DateTime));

            EmployeesDataTable.Rows.Add(1, "Abdulkareem", "Yemen", 5000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Mohammed", "Jordan", 3000, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "Waleed", "Sariya", 4000, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "Ahmed", "Egypt", 750.7, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Lina", "Yemen", 800.5, DateTime.Now);

            foreach(DataRow row in EmployeesDataTable.Rows)
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


            Console.ReadKey();

        }
    }
}
