using System;

using System.Threading.Tasks;

namespace Parallel_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterations = 10;
            Parallel.For(0, iterations ,i=>
            {
                Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");
                // Simulate some work
                Task.Delay(1000).Wait();
            });

            Console.WriteLine("\niterations completed using lambda");

            Parallel.For(0, iterations, IterationProcess);
            Console.WriteLine("\niterations completed");


            Console.ReadKey();
        }

        public static void IterationProcess(int i)
        {
            Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");
            // Simulate some work
            Task.Delay(1000).Wait();
        }

    }
}
