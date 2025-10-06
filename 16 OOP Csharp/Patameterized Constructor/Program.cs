using System;

namespace Patameterized_Constructor
{

    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Age { get; set; }
        // paramerterized constructor 
        public clsPerson(int id , string name , short age )
        {
            this.Id =id ;
            this.Name = name;
            this.Age = age;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {

            clsPerson Person1 = new clsPerson(10, "Abdulkareem Shawqi", 20);

            Console.WriteLine($"ID = {Person1.Id}");
            Console.WriteLine($"Name = {Person1.Name}");
            Console.WriteLine($"Age = {Person1.Age}");

            Console.ReadKey();
        }
    }
}
