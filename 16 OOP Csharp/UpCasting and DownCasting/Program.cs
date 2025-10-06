using System;

namespace UpCasting_and_DownCasting
{

    class clsPerson
    {
        public string Name { get; set; }
        public short Age { get; set; }

        public void Greeting()
        {
            Console.WriteLine($"Hi,My name is {Name} and I am {Age} years old");
        }


    }

    class clsEmployee : clsPerson
    {
        public string Company { get; set; }
        public float Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($" I am working at {Company} and earn {Salary:C} per month");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            // upcasting is useful (faster and space safer) because
            //  we don't want to deal with the properties and methods in the 
            // derived class and this 


            //  Upcasting is from the big to the small
            clsEmployee Employee1 = new clsEmployee {Name ="Abdulkareem",Age = 20,Company ="CopXYZ",Salary = 5000  };
            clsPerson Person = Employee1;
            
            Person.Greeting();

            // rarely used
            // Downcasting is valid in some cases like following
            clsPerson Person2 = new clsEmployee { Name = "Abdulkareem", Age = 20, Company = "CopXYZ", Salary = 5000 };
            clsEmployee Employee2 = (clsEmployee)Person2;
            Employee1.Work();

            // Invalid downcasting - throws InvalidCastException at runtime
            //clsPerson Person3 = new clsPerson { Name = "John", Age = 30 };
            //clsEmployee Employee3 = (clsEmployee)Person3;


            Console.ReadKey();
        }
    }
}
