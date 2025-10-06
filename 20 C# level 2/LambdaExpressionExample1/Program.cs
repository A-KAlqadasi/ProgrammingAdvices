using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionExample1
{
    internal class Program
    {
        
        static Func<int, int> Square = x=> x* x;

      
        static void Main(string[] args)
        {

            int result2 = Square(6);
            Console.WriteLine($"Square Result using Func and lambda = {result2}");

            Console.Read();
        }
    }
}
