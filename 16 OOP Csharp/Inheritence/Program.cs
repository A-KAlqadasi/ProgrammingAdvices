using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{

    public class clsPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public string FullName
        {
            // get for reading the property
            get
            {
                return FirstName + " "+LastName;
            }
        }


    }

    public class clsEmployee : clsPerson
    {
        public float Salary { get; set; }
        public string DepartmentName { get; set; }
        
        public void IncreaseSalaryBy(float amount )
        {
            Salary += amount;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            // Create an object of employee
            clsEmployee Employee1 = new clsEmployee();

            Console.WriteLine("Accessing Object 1 (Employee1):\n");

            // the following inherited from base class Person
            Employee1.Id = 10;
            Employee1.Title = "Mr.";
            Employee1.FirstName = "Abdulkareem";
            Employee1.LastName = "Shawqi";

            // the following are from derived class Employee
            Employee1.Salary = 5000;
            Employee1.DepartmentName = "Software Engineering";

            Console.WriteLine($"ID: {Employee1.Id}");
            Console.WriteLine($"Title: {Employee1.Title}");
            Console.WriteLine($"Full Name: {Employee1.FullName}");
            Console.WriteLine($"Department: {Employee1.DepartmentName}");
            Console.WriteLine($"Salary: {Employee1.Salary}");

            Employee1.IncreaseSalaryBy(100);
            Console.WriteLine($"Salary after increasing : {Employee1.Salary}");


            Console.ReadKey();
        }
    }
}
