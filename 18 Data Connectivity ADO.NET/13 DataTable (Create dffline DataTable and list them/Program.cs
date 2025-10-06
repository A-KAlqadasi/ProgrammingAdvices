using System;
using System.Data;
using System.Linq;


namespace DataTablesOffline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable();

            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name",typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary",typeof(Double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            EmployeesDataTable.Rows.Add(1,"Abdulkareem","Yemen",5000,DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Mohammed Abu-Hadhoud","Jordan", 5000, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "Mohammed Basheer","Yemen",2000, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "Mohammed Maher","Lebanon", 6000, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Ali Salem","Egypt", 3000, DateTime.Now);


            Console.WriteLine("\nEmplyees List:\n");
            foreach(DataRow row in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID:  {row["ID"]} \tName: {row["Name"]}" +
                    $"\tCountry: {row["Country"]}\tSalary: {row["Salary"]}\tDate: {row["Date"]}");
            }

            Console.ReadLine();

        }
    }
}
