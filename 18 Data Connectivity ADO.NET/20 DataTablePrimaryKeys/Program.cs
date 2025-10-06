using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_DataTablePrimaryKeys
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

            //Setting primary key 
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];// [1]  means one column as primary key
            PrimaryKeyColumns[0] = EmployeesDataTable.Columns["ID"];
            EmployeesDataTable.PrimaryKey= PrimaryKeyColumns;




            Console.WriteLine("\n\nEmployees List:\n");

            foreach (DataRow row in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}\tName: {row["Name"]}" +
                    $"\tCountry: {row["Country"]}\tSalary: {row["Salary"]}\tDate: {row["Date"]}");
            }
            //Departments Data Table

            DataTable departmentsDT = new DataTable();
            departmentsDT.Columns.Add("ID", typeof(int));
            departmentsDT.Columns.Add("Name", typeof(string));
            departmentsDT.Columns.Add("Location", typeof(string));

            DataColumn[] departmentsPK =new DataColumn[1];
            departmentsPK[0] = departmentsDT.Columns["ID"];
            departmentsDT.PrimaryKey= departmentsPK;

            departmentsDT.Rows.Add(1, "IT", "Sana'a");
            departmentsDT.Rows.Add(2, "CS", "Taizz");
            departmentsDT.Rows.Add(3, "Marketing", "Taizz");


            Console.WriteLine("\n\nDepartments list: \n");
            foreach (DataRow row in departmentsDT.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}\tName: {row["Name"]}\tLocation: {row["Location"]}");
            }

            Console.ReadKey();
        }
    }
}
