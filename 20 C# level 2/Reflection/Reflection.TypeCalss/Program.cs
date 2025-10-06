using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.TypeCalss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(string);

            Console.WriteLine("Type information");
            Console.WriteLine($"Name: {myType.Name}");
            Console.WriteLine($"Full Name: {myType.FullName}");
            Console.WriteLine($"Is Class: {myType.IsClass}");


            Console.ReadKey();
        }
    }
}
