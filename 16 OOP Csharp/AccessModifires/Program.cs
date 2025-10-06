using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifires
{

    class clsA
    {
        // fields
        public int x1 = 10;
        private int x2 = 20;
        protected int x3 = 30;

        // methods

        public int Func1()
        {
            return 100;
        }

        private int Func2()
        {
            return 200;
        }

        protected int Func3()
        {
            return 300;
        }


    }

    class clsB : clsA
    {
        protected int Func4()
        {
            return x1 + x3;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // create object from class A
            clsA A = new clsA();

            // all public members are accessable and internal
            Console.WriteLine("All public memebers are accessable");
            Console.WriteLine("x1 ={0}",A.x1);
            Console.WriteLine("result of Func1={0}", A.Func1());

            // you cannot access private members in the following line
            //Console.WriteLine("x2={0}", A.x2);

            // you cannot access private members in the following line
            //Console.WriteLine("result of Func2={0}", A.Func2());

            // you cannot access protected members in the following line
            //Console.WriteLine("result of Func3={0}", A.Func3());

            clsB B = new clsB();
            Console.WriteLine("\nObjects from class B expose all public members from class A");
            Console.WriteLine("x1={0}",B.x1);
            Console.WriteLine("result of Func1={0}", B.Func1());




            Console.ReadKey();

        }
    }
}
