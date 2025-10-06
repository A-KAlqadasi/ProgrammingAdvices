using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegateWithLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize Action delegate with regular methods
            Action parameterLessAction = ()=> { Console.WriteLine("This is parameter less action"); };
            Action<int> actionWithIntParameter = (x)=> { Console.WriteLine($"Action with parameter int ={x}"); };
            Action<string, int> actionWithTwoParameterMethod = (message, num)=> { Console.WriteLine($"Action with parameter string ={message}, int ={num}"); };

            // Invoke the actions
            parameterLessAction();
            actionWithIntParameter(100);
            actionWithTwoParameterMethod("Hello, World!", 200);

            Console.ReadKey();
        }
      

    }
}
