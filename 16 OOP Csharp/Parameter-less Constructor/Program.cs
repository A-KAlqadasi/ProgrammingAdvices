using System;

namespace Parameter_less_Constructor
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


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person = new clsPerson();

            Console.WriteLine($"ID = {Person.Id}");
            Console.WriteLine($"Name = {Person.Name}");
            Console.WriteLine($"Age = {Person.Age}");

            Console.ReadKey();
        }
    }
}
