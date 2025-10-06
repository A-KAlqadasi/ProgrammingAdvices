using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Inheritence
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

    class clsDoctor: clsEmployee
    {
        public string Speciality { get; set; }

        public void Heal()
        {
            Console.WriteLine($"Doctor {Name} with ID {EmployeeID}, " +
                $"salary {Salary:C}, and speciality {Speciality} is healing passion");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            clsDoctor Doctor = new clsDoctor();
            Doctor.Name = "Ahmed";
            Doctor.Age = 35;
            Doctor.EmployeeID = 123;
            Doctor.Salary = 20000;
            Doctor.Speciality = "Brain & Nervs";

            Doctor.Introduce();
            Doctor.Work();
            Doctor.Heal();

            Console.ReadKey();

        }
    }
}
