using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize Action delegate with regular methods
            Action parameterLessAction = ParameterLessMethod;
            Action<int> actionWithIntParameter = ActionWithIntParameterMethod;
            Action<string, int> actionWithTwoParameterMethod = ActionWithTwoParameterMethod;

            // Invoke the actions
            parameterLessAction();
            actionWithIntParameter(100);
            actionWithTwoParameterMethod("Hello, World!", 200);

            Console.ReadKey();
        }
        static void ParameterLessMethod()
        {
            Console.WriteLine("This is parameter less action");
        }

        static void ActionWithIntParameterMethod(int num)
        {
            Console.WriteLine($"Action with parameter int ={num}");
        }

        static void ActionWithTwoParameterMethod(string message, int num)
        {
            Console.WriteLine($"Action with parameter string ={message}, int ={num}");
        }

    }
}
