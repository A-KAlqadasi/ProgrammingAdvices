using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_Foreach
{
    internal class Program
    {
        static List<string> _urls = new List<string>
        {
            "https://ProgrammingAdvices.com",
            "https://cnn.com",
            "https://amazon.com"
        };
        static void Main(string[] args)
        {
            Parallel.ForEach(_urls ,url=>DownloadContent(url));
            Console.WriteLine("\nDone!");
            Console.ReadKey();
        }
        static void DownloadContent(string url)
        {
            string content;


            using (WebClient client = new WebClient())
            {
                // Simulate some work by adding a delay
                Thread.Sleep(100);


                // Download the content of the web page
                content = client.DownloadString(url);
            }


            Console.WriteLine($"{url}: {content.Length} characters downloaded");
        }
    }
}
