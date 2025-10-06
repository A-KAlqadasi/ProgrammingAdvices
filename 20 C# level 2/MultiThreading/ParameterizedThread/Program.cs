using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Note that your program is the main thread.

            // Create a new thread and start it
            Thread t = new Thread(()=>Method1("Thread1"));
            t.Start();

            Thread t2 = new Thread(()=>Method2("Thread2"));
            t2.Start();

            //Method1();
            t.Join();
            t2.Join();

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Main: " + i);
                Thread.Sleep(500);
            }

            Console.ReadKey();
        }

        static void Method1(string threadName)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{threadName}, Method1: " + i);
                Thread.Sleep(500);
            }
        }
        static void Method2(string threadName)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{threadName}, Method2: " + i);
                Thread.Sleep(500);
            }
        }

    }
}
