using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOperationNoLambda
{
    internal class Program
    {
        delegate int Operation(int x, int y);

        static void DoOperation(int x, int y, Operation operation)
        {
            int result = operation(x, y);
            Console.WriteLine($"result : {result}");
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Sub(int x, int y)
        {
            return x - y;
        }

        static void Main(string[] args)
        {
            Operation sumOp = new Operation(Sum);
            Operation subOp = new Operation(Sub);

            DoOperation(10,20,sumOp);
            DoOperation(10,20,subOp);

            Console.Read();
        }
    }
}
