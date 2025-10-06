using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplemented_Properties
{

    class clsEmployee
    {
        

        public int ID
        {
            get;
            set;

        }

        public string Name
        {
            get;
            set;

        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Employee = new clsEmployee();

            Employee.ID = 1;
            Employee.Name = "Abdulkareem";

            Console.WriteLine($"ID : {Employee.ID}");
            Console.WriteLine($"Name : {Employee.Name}");

            Console.ReadKey();
        }
    }
}
