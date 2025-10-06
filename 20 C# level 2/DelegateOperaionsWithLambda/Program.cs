using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace DelegateOperaionsWithLambda
{
    internal class Program
    {
        delegate int Operation(int x, int y);

        static void DoOperation(int x, int y, Func<int,int,int> operation)
        {
            int result = operation(x, y);
            Console.WriteLine($"result : {result}");
        }
        static Func<int, int, int> sumOp = (x, y) => x + y;
        static Func<int, int, int> subOp = (x, y) => x - y;


        static void Main(string[] args)
        {


            Console.WriteLine(Sqrt(36));
            DoOperation(10, 20, sumOp);
            DoOperation(10,20,subOp);


            Console.Read();
        }
    }
}
