using System;
using MyClassLibrary;

namespace TestMyFirstClassLibraryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMyMath myMath = new clsMyMath();

            Console.WriteLine(myMath.Sum(10,20));
            Console.WriteLine(myMath.Sum(10, 20,30));


            Console.ReadKey();
        }
    }
}
