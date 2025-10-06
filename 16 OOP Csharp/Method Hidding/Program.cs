using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hidding
{
    class MyBaseClass
    {

        public virtual void Method()
        {
            Console.WriteLine("Base class Implementaion of Method");
        }

        public virtual void Method2() 
        {
            Console.WriteLine("Base class Implementaion of Method2");
        }


    }

    class MyDerivedClass : MyBaseClass
    {
        public override void Method()
        {
            Console.WriteLine("Derived class Impelementaion of Method");
        }

        // in method hiding, you can redefine the method of the base class
        // in the derived class by using the new keyword.
        public new void Method2()
        {
            Console.WriteLine("Derived class Impelementaion of Method2");
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {

            MyBaseClass myBaseObj = new MyBaseClass();
            Console.WriteLine("\nBase Object:\n");
            myBaseObj.Method();
            myBaseObj.Method2();

            MyDerivedClass myDerivedObj = new MyDerivedClass();
            Console.WriteLine("\nDerived Object:\n");
            myDerivedObj.Method();
            myDerivedObj.Method2();

            MyBaseClass myDerivedClassAsBase = myDerivedObj;
            Console.WriteLine("\nAfter casting");
            myDerivedClassAsBase.Method();
            myDerivedClassAsBase.Method2();

            Console.ReadKey();
        }
    }
}
