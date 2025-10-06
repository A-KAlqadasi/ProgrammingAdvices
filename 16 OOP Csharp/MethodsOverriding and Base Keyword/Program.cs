using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOverriding_and_Base_Keyword
{

    public class clsA
    {
        //virtual - allows the method to be overridden by the derived class
        public virtual void Print()
        {
            Console.WriteLine("Hi, I'm the print method from the base class a");
        }
    }

    public class clsB : clsA
    {
        //override - indicates the method is overriding the method from the base class
        public override void Print()
        {
            Console.WriteLine("Hi, I'm the print method from the derived class B");
            //base keyword is used to call the Print method in the base class.

            base.Print();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            clsB ObjB = new clsB();
            ObjB.Print();

            Console.ReadKey();

        }
    }
}
