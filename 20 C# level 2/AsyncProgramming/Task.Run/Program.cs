using System;
using System.Threading;
using System.Threading.Tasks;

namespace RentMultipleTasks.Run
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = Task.Run(() => DownloadFile("Download File 1"));
            Task task2 = Task.Run(() => DownloadFile("Download File 2"));

            await Task.WhenAll(task1, task2);

            Console.WriteLine("Task 1 and 2 completed");
            Console.ReadKey();

        }
        public static void DownloadFile(string fileName)
        {
            Console.WriteLine($"{fileName} started");
            Thread.Sleep(5000);
            Console.WriteLine($"{fileName} completed");

        }
    }
}
