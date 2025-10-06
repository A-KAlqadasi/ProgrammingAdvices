using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{

    class clsPerson
    {
        // field members
        public string FirstName;
        public string LastName;

        // Method member
        public string FullName()
        {
            return FirstName + " " + LastName;
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object from class
            clsPerson Person1 = new clsPerson();

            Console.WriteLine("Accessing Object 1 (Person)");
            Person1.FirstName = "Abdulkareem";
            Person1.LastName = "Shawqi";
            Console.WriteLine(Person1.FullName());

            // create another object from class
            clsPerson Person2 = new clsPerson();

            Console.WriteLine("\nAccessing Object 2 (Person)");
            Person1.FirstName = "Waleed";
            Person1.LastName = "Awn";
            Console.WriteLine(Person1.FullName());

            Console.ReadKey();
        }
    }
}
