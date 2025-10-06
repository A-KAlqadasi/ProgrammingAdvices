using System;
using System.Data;
using System.Linq;

namespace DataTableAutoIncrementAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable();

            //short way to define columns 
            //EmployeesDataTable.Columns.Add("ID", typeof(int));
            //EmployeesDataTable.Columns.Add("Name", typeof(string));
            //EmployeesDataTable.Columns.Add("Country", typeof(string));
            //EmployeesDataTable.Columns.Add("Salary", typeof(Double));
            //EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            //detailed way to define columns 
            DataColumn dtColumn;
            dtColumn = new DataColumn();
            dtColumn.DataType= typeof(int);
            dtColumn.ColumnName= "ID";
            
            dtColumn.AutoIncrement=true;
            dtColumn.AutoIncrementSeed = 1;
            dtColumn.AutoIncrementStep= 1;

            dtColumn.Caption = "Employee ID";
            dtColumn.Unique=true;
            dtColumn.ReadOnly=true;

            EmployeesDataTable.Columns.Add(dtColumn);
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Name";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Name";
            dtColumn.Unique=false;
            dtColumn.ReadOnly=false;

            EmployeesDataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType=typeof(string);
            dtColumn.ColumnName = "Country";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Country";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;

            EmployeesDataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Double);
            dtColumn.ColumnName = "Salary";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Employee Salary";
            dtColumn.Unique=false;
            dtColumn.ReadOnly=false;

            EmployeesDataTable.Columns.Add(dtColumn);
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);
            dtColumn.ColumnName = "Date";
            dtColumn.DefaultValue = DateTime.Now;
            dtColumn.Unique = false;
            dtColumn.ReadOnly=true;
            EmployeesDataTable.Columns.Add(dtColumn);

            DataColumn[] pkColumn = new DataColumn[1];
            pkColumn[0] = EmployeesDataTable.Columns["ID"];
            EmployeesDataTable.PrimaryKey= pkColumn;


            EmployeesDataTable.Rows.Add(null, "Abdulkareem", "Yemen", 5000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null,"Mohammed", "Jordan", 3000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null,"Waleed", "Sariya", 4000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null,"Ahmed", "Egypt", 750.7, DateTime.Now);
            EmployeesDataTable.Rows.Add(null,"Lina", "Yemen", 800.5, DateTime.Now);


            Console.WriteLine("\n\nEmployees List:\n");

            foreach (DataRow row in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}\tName: {row["Name"]}" +
                    $"\tCountry: {row["Country"]}\tSalary: {row["Salary"]}\tDate: {row["Date"]}");
            }
            Console.ReadLine();
        }
    }
}
