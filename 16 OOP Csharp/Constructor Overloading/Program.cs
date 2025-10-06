using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{


    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        // paramerter less constructor 
        public clsPerson()
        {
            Id = -1;
            Name = "Empty";
            Age = 0;
        }

        //parameterized constructor
        public clsPerson(int id, string name, short age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {

            clsPerson Person1 = new clsPerson();
            Console.WriteLine("Calling the parameter less constructor");
            Console.WriteLine($"ID = {Person1.Id}");
            Console.WriteLine($"Name = {Person1.Name}");
            Console.WriteLine($"Age = {Person1.Age}");


            clsPerson Person2 = new clsPerson(10, "Abdulkareem Shawqi", 20);
            Console.WriteLine("\n\nCalling the parameterized constructor");

            Console.WriteLine($"ID = {Person2.Id}");
            Console.WriteLine($"Name = {Person2.Name}");
            Console.WriteLine($"Age = {Person2.Age}");

        }
    }
}
