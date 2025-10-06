using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Constructor
{

    class clsPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public clsPerson(int Id , string FirstName , string LastName, string Title)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
        }





    }

    class clsEmployee : clsPerson
    {
        public float Salary { get; set; }
        public string DepartmentName { get; set; }

        public clsEmployee(int Id, string FirstName,string LastName, string Title,
            float Salary ,string DepartmentName) : base(Id,FirstName, LastName, Title) 
        {
            this.Salary = Salary;
            this.DepartmentName = DepartmentName;
        }

        public void IncreaseSalaryBy(float Amont)
        {
            Salary += Amont;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            clsEmployee Employee1 = new clsEmployee(10,"Abdulkareem","Shawqi","Mr",5000,"Software Engineering");

            Console.WriteLine("Accessing Object 1 (Employee1):\n");

            Console.WriteLine($"ID := {Employee1.Id}");
            Console.WriteLine($"Full Name:= {Employee1.FullName}");
            Console.WriteLine($"Title := {Employee1.Title}");
            Console.WriteLine($"Department Name := {Employee1.DepartmentName}");
            Console.WriteLine($"Salary := {Employee1.Salary}");

            Employee1.IncreaseSalaryBy(100);
            Console.WriteLine($"Salary after increase := {Employee1.Salary}");


            Console.ReadKey();
        }
    }
}
