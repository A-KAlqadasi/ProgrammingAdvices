using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{

    class clsPerson
    {
        public clsPerson()
        {
            Console.WriteLine("Constructor is called");
        }

        //destructor (finalizer) is used to destroy objects of class
        //when the scope of an object ends.

        ~clsPerson()
        {
            Console.WriteLine("Destructor is called");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson P1 = new clsPerson();

            Console.ReadKey();
        }
    }
}
