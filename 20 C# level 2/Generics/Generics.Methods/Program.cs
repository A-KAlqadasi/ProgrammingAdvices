using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Methods
{
    class Utility
    {
        public static void Swap<T> (ref T value1, ref T value2)
        {
            T temp = value1; ;
            value1 = value2;
            value2 = temp;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            int value1 =10, value2 =20;
            Console.WriteLine($"before swaping: value1= {value1}, value2= {value2}");

            Utility.Swap(ref value1,ref value2);
            Console.WriteLine($"afte swaping: value1= {value1}, value2= {value2}");

            string msg1 = "Hello", msg2 = "World";
            Console.WriteLine($"Before sawping: {msg1}, {msg2}");
            Utility.Swap(ref msg1,ref msg2);
            Console.WriteLine($"After sawping: {msg1}, {msg2}");


            Console.ReadKey();
        }
    }
}
