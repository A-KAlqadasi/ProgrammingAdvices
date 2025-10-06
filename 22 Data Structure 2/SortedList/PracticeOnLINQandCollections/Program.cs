using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticeOnLINQAndCollections
{
	internal class Program
	{
		static void Main(string[] args)
		{

			SortedList<int, Employee> employees = new SortedList<int, Employee>
			{
				{1, new Employee("Ahmed","IT",50000) },
				{2, new Employee("Ali","IT",40000) },
				{3, new Employee("Mohammed","IS",50000) },
				{4, new Employee("Waleed","CS",20000) },
				{5, new Employee("Waleed","CS",20000) },
				{6, new Employee("Yousef","HR",30000) }

			};

			var maxSalary = employees.Max(e => e.Value.Salary);
			var minSalary = employees.Min(e => e.Value.Salary);

			Console.WriteLine($"Min salary: {minSalary}, max salary: {maxSalary}");

			float? secondMaxSalary = employees.FirstOrDefault(e => e.Value.Salary < (employees.Max(e2 => e2.Value.Salary))).Value?.Salary;
			Console.WriteLine("Second Max salary: " + secondMaxSalary);


			Console.WriteLine("\nemployees from the sortedList");

			foreach(var employee in employees)
			{
				Console.WriteLine(employee.Value);
			}

			

			HashSet<Employee> employees3 = new HashSet<Employee>(employees.Values);
			
			Console.WriteLine("\nRemoving the repeated employees from the sortedList");
			foreach(var employee in employees3)
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


		public override int GetHashCode()
		{
			int hashCodeName = Name != null ? Name.GetHashCode() : 0 ;
			int hashCodeDepartment = Department != null ? Department.GetHashCode() : 0;
			int hashCodeSalary = Salary.GetHashCode();

			return hashCodeName ^ hashCodeDepartment ^ hashCodeSalary;
			
		}

		public override bool Equals(object obj)
		{
			if (obj is Employee other)
			{
				return Name == other.Name && 
					Department == other.Department &&
					Salary == other.Salary;
			}
			return false;
		}

	}
}
