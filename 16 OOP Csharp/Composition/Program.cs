using System;


namespace Composition
{

    public class clsA
    {
        public void Method1()
        {
            Console.WriteLine("Method 1 of class A is called");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2 of class A is called");
            Console.WriteLine("Now i will call method1 of class B");
            clsB objB = new clsB();
            objB.Method1();
        }


    }


    public class clsB
    {
        public void Method1()
        {
            Console.WriteLine("Method 1 of class B is called");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            clsA objA = new clsA();
            objA.Method1();
            objA.Method2();

            Console.ReadKey();
        }
    }
}
