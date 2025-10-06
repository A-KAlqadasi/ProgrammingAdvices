using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace TaskClassExample2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = DownloadWebsiteAsync("https://www.cnn.com");
            Console.WriteLine("Task 1 started");
            Task task2 = DownloadWebsiteAsync("https://www.amazon.com");
            Console.WriteLine("Task 2 started");

            Task task3 = DownloadWebsiteAsync("https://www.ProgrammingAdvices.com");
            Console.WriteLine("Task 3 started");

            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("\nDone all tasks finished!");
            Console.ReadKey();

        }

        static async Task DownloadWebsiteAsync(string url)
        {
            string content;

            using (WebClient client = new WebClient())
            {
                // Simulate some work by adding a delay
                await Task.Delay(100);

                // Download the content of the web page
                content = await client.DownloadStringTaskAsync(url);
            }

            Console.WriteLine($"{url}: {content.Length} characters downloaded");
        }
    }
}
