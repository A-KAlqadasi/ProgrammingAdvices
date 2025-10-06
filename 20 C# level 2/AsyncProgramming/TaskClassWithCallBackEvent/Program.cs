using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskClassWithCallBackEvent
{
    public class CallBackEventArgs : EventArgs
    {
        public int Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public CallBackEventArgs(int parameter1, string parameter2)
        {
            Parameter1 = parameter1;
            Parameter2 = parameter2;
        }
    }
    internal class Program
    {
        public delegate void CallBackEventHandler(object sender, CallBackEventArgs e);
        public static event CallBackEventHandler CallBackEvent;


        static async Task Main(string[] args)
        {
            CallBackEvent += OnCallBackEventRecieved;
            CallBackEvent += OnCallBackEventRecieved2;

            Task task1 = performAsyncOperation(CallBackEvent);

            Console.WriteLine("Do something");

            await task1;
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static async Task performAsyncOperation(CallBackEventHandler callBack)
        {
            await Task.Delay(4000);
            
            callBack?.Invoke(null, new CallBackEventArgs(20, "Abdulkareem"));
        }

        private static void OnCallBackEventRecieved(object sender, CallBackEventArgs e)
        {
            Console.WriteLine($"data recived by Func1 :{e.Parameter1}, {e.Parameter2}");
        }
        private static void OnCallBackEventRecieved2(object sender, CallBackEventArgs e)
        {
            Console.WriteLine($"data recived by Func2 :{e.Parameter1}, {e.Parameter2}");
        }
    }
}
