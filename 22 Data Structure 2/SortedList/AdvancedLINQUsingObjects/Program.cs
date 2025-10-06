using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedLINQUsingObjects
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SortedList<int, Employee> employees = new SortedList<int, Employee>
			{
				{1, new Employee("Ahmed","IT",50000) },
				{2, new Employee("Ali","IT",40000) },
				{3, new Employee("Mohammed","IS",30000) },
				{4, new Employee("Waleed","CS",10000) },
				{5, new Employee("Abdulkareem","CS",20000) },
				{6, new Employee("Yousef","HR",30000) }
			
			};
			
			var employeesGroupByDepartment = employees.GroupBy(e => e.Value.Department);

			Console.WriteLine("\nGroup by Departments and sum salaries:\n");
			foreach (var employee in employeesGroupByDepartment)
			{
				Console.WriteLine($"Department: {employee.Key}: Total Salaries: {employee.Sum(e=>e.Value.Salary)}"); 
			}

			
			var employeesInIT = employees.Where(e => e.Value.Department == "CS")
								.OrderByDescending(e => e.Value.Salary)
								.Select(e => e.Value);
			Console.WriteLine("\nAll employees in CS department sorted by Salary desc\n");

			foreach(var employee in employeesInIT)
			{
				Console.WriteLine(employee);
			}



			Console.ReadKey();
		}
	}

	public class Employee
	{
		public Employee(string name, string department, float salary)
		{
			Name = name;
			Department = department;
			Salary = salary;
		}

		public string Name { get; set; }
		public string Department { get; set; }
		public float Salary { get; set; }

		public override string ToString()
		{
			return $"Name= {Name}, Department= {Department}, Salary= {Salary}";
		}

	}

}
