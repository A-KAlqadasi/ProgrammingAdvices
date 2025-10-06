//#define TRACE_ENABLED

using System;
using System.Diagnostics;


namespace ConditionalAttributeExample
{
    internal class TraceExample
    {
        [Conditional("TRACE_ENABLED")] // this will be enabled if we define it 
        public void TraceMethod1(string message)
        {
            Console.WriteLine($"[TRACE1]: {message}");
        }
        [Conditional("koko")]

        public void TraceMethod2(string message)
        {
            Console.WriteLine($"[TRACE2]: {message}");
        }

    }
}
