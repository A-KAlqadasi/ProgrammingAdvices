using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TaskCallExampleWithEvent
{
    public class DownloadCompleteEventArgs:EventArgs
    {
        public string Url { get; set; }
        public string ContentLength { get; set; }
        public DownloadCompleteEventArgs(string url, string contentLength)
        {
            Url = url;
            ContentLength = contentLength;
        }
    }
    internal class Program
    {
        public delegate void DownloadCompleteHandler(object sender, DownloadCompleteEventArgs e);
        public static event DownloadCompleteHandler DownloadCompleteEvent;

        static async Task Main(string[] args)
        {
            DownloadCompleteEvent += OnDownloadCompleteEvent;
            
            Task task1 = DownloadWebsiteAsync("https://www.cnn.com", DownloadCompleteEvent);
            Console.WriteLine("Task 1 started");
            Task task2 = DownloadWebsiteAsync("https://www.amazon.com", DownloadCompleteEvent);
            Console.WriteLine("Task 2 started");

            Task task3 = DownloadWebsiteAsync("https://www.ProgrammingAdvices.com", DownloadCompleteEvent);
            Console.WriteLine("Task 3 started");

            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("\nDone all tasks finished!");
            Console.ReadKey();

        }

        private static void OnDownloadCompleteEvent(object sender, DownloadCompleteEventArgs e)
        {

            Console.WriteLine($"{e.Url}: {e.ContentLength} characters downloaded");
        }

        static async Task DownloadWebsiteAsync(string url, DownloadCompleteHandler downloadComplete)
        {
            string content;

            using (WebClient client = new WebClient())
            {
                // Simulate some work by adding a delay
                await Task.Delay(100);

                // Download the content of the web page
                content = await client.DownloadStringTaskAsync(url);
            }
            downloadComplete?.Invoke(null, new DownloadCompleteEventArgs(url, content.Length.ToString()));
        }
    }
}
