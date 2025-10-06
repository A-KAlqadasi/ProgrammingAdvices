using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    public class clsOuterClass
    {
        public int OuterVariable { get; set; }

        public clsOuterClass(int Variable)
        {
            OuterVariable = Variable;
        }

        public void OtuerMethod()
        {
            Console.WriteLine("Outer Method called.");
        }


        public class clsInnerClass
        {
            public int InnerVariable { get; set;}

            public clsInnerClass(int Variable)
            {
                InnerVariable = Variable;
            }

            public void InnerMethod()
            {
                Console.WriteLine("Inner Method called.");
            }

            public void AccessingOuterVariable(clsOuterClass outer)
            {
                Console.WriteLine($"Accessing Outer Vairable is {outer.OuterVariable}");
            }

        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // create an instanceof OuterClass
            clsOuterClass outer1 = new clsOuterClass(100);

            //create an instance of InnerClass
            clsOuterClass.clsInnerClass inner1 = new clsOuterClass.clsInnerClass(200);

            outer1.OtuerMethod();
            inner1.InnerMethod();
            inner1.AccessingOuterVariable(outer1);

            Console.ReadKey();
        }
    }
}
