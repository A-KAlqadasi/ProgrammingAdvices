using System;
using System.Data;
using System.Linq;


namespace DataSetsCreation
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

            DataTable departmentsDataTable = new DataTable();
            departmentsDataTable.Columns.Add("DepartmentID", typeof(int));
            departmentsDataTable.Columns.Add("Name",typeof(string));

            departmentsDataTable.Rows.Add(1, "IT");
            departmentsDataTable.Rows.Add(2, "Marketing");
            departmentsDataTable.Rows.Add(3, "HR");

            Console.WriteLine("\n\nDepartments list\n");
            foreach (DataRow row in departmentsDataTable.Rows)
            {
                Console.WriteLine($"ID: {row["DepartmentID"]}\tName: {row["Name"]}");
            }

            //create dataSet
            DataSet dataSet1 = new DataSet();

            dataSet1.Tables.Add(EmployeesDataTable);
            dataSet1.Tables.Add (departmentsDataTable);

            Console.WriteLine("\n\nPrinting employees data from data set\n");
            foreach(DataRow row in dataSet1.Tables[0].Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}\tName: {row["Name"]}" +
                    $"\tCountry: {row["Country"]}\tSalary: {row["Salary"]}\tDate: {row["Date"]}");
            }
            Console.WriteLine("\n\nPrinting departments data from data set\n");

            foreach (DataRow row in dataSet1.Tables[1].Rows)
            {
                Console.WriteLine($"ID: {row["DepartmentID"]}\tName: {row["Name"]}");

            }


            Console.ReadLine();
        }
    }
}
