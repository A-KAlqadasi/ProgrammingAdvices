using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchal_Inheritence
{

    class clsPerson
    {
        public string Name { get; set; }
        public short Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi,My name is {Name} and I am {Age} years old");
        }


    }

    class clsEmployee : clsPerson
    {
        public short EmployeeID { get; set; }
        public float Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($" Employee with ID {EmployeeID} and salary {Salary:C} is working");
        }
    }

    class clsUser : clsPerson
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }

        public void Info()
        {
            Console.WriteLine($" User: {UserName} and password {Password}");

        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Employee1 = new clsEmployee();

            Employee1.Name = "John";
            Employee1.Age = 35;
            Employee1.EmployeeID = 123;
            Employee1.Salary = 5000;
            Console.WriteLine("\nEmployee Info:\n");
            Employee1.Introduce();
            Employee1.Work();

            clsUser User1 = new clsUser();
            User1.Name = "Ali";
            User1.Age = 30;
            User1.UserName = "User1";
            User1.Permissions = 1;
            User1.Password = "p1234";
            Console.WriteLine("\nUser Info:\n");
            User1.Introduce();
            User1.Info();

            Console.ReadKey();
        }
    }
}
