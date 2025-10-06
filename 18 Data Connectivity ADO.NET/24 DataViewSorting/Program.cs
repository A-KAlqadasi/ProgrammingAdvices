using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_DataViewSorting
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

            //create dataview 
            DataView EmployeesDataView1 = EmployeesDataTable.DefaultView;
            Console.WriteLine("\n\nEmployees list from data view\n");

            for (int i = 0; i < EmployeesDataView1.Count; i++)
            {
                Console.WriteLine($"{EmployeesDataView1[i][0]}, {EmployeesDataView1[i][1]}, {EmployeesDataView1[i][2]}, " +
                    $"{EmployeesDataView1[i][3]}, {EmployeesDataView1[i][4]}");
            }

            // sorting using dataview faster than datatable

            EmployeesDataView1.Sort = "Name ASC";
            
            Console.WriteLine("\n\nEmployees list from data view after sorting\n");

            for (int i = 0; i < EmployeesDataView1.Count; i++)
            {
                Console.WriteLine($"{EmployeesDataView1[i][0]}, {EmployeesDataView1[i][1]}, {EmployeesDataView1[i][2]}, " +
                    $"{EmployeesDataView1[i][3]}, {EmployeesDataView1[i][4]}");
            }


            Console.ReadKey();

        }
    }
}
