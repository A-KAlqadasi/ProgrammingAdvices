using System;
// the namespace is a part of Task Parallel library (TPL)
using System.Threading.Tasks;

namespace TaskClass
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task<int> taskResult = performAsyncOperation();


            Console.WriteLine("Doning something..");

            int result = await taskResult;

            Console.WriteLine("Result "+result);
            Console.ReadLine();
        }

        static async Task<int> performAsyncOperation()
        {
            await Task.Delay(4000);

            return 42;
        }
    }
}
