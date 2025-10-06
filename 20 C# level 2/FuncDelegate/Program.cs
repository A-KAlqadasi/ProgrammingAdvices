using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{

    
    internal class Program
    {
        delegate int SquareDelegate(int x);

        // Define a Func delegate for squaring a number 
        static Func<int, int> Square = SquareMethod;

        static int SquareMethod(int x)
        {
            return x * x;
        }

        static void Main(string[] args)
        {

            SquareDelegate square = new SquareDelegate(SquareMethod);
            
            
            int result = square(5);
            Square = SquareMethod;
            int result2 = Square(6);
            Console.WriteLine($"Square Result = {result}");
            Console.WriteLine($"Square Result using Func = {result2}");

            Console.Read();
        }
    }
}
