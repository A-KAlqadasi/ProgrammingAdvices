using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableDataTypeExample2
{
    internal class Program
    {
        static void Procedure1(string name, Nullable<int> age)
        {
            Console.WriteLine("Name : "+name);
            if(age.HasValue)
                Console.WriteLine("Age: "+age.Value);
            else
                Console.WriteLine("Age is null");
        }
        static void Procedure2(string name, int? age)
        {
            Console.WriteLine("Name : " + name);
            if (age.HasValue)
                Console.WriteLine("Age: " + age.Value);
            else
                Console.WriteLine("Age is null");
        }
        static void Main(string[] args)
        {

            Procedure1("Abdulkareem Shawqi", null);
            Procedure1("Abdulkareem Shawqi", 20);

            Procedure2("Abdulkareem Shawqi", null);
            Procedure2("Abdulkareem Shawqi", 20);
            Console.ReadLine();
        }
    }
}
