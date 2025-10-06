//#define TRACE_ENABLED

using System;
using System.Diagnostics;


namespace ConditionalAttributeExample
{
    public class MyClass
    {
        [Conditional("DEBUG")]
        public void DebugMethod()
        {
            Console.WriteLine("Debug method executed!");
        }
        public void NormalMethod()
        {
            Console.WriteLine("Normal method executed!");
        }

    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.DebugMethod();
            myClass.NormalMethod();

            TraceExample trace = new TraceExample();
            trace.TraceMethod1("This trace method will be execute if TRACE_ENABLED is defined");
            trace.TraceMethod2("This trace method will be execute if koko is defined");



            Console.ReadKey();
        }
    }
}
