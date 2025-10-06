using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelegate
{
    internal class Program
    {
         
        static Predicate<int> IsEvenPredicate = IsEven;

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static void Main(string[] args)
        {
            var result = IsEvenPredicate(5);
            Console.WriteLine($"Is number 5 Even? {result}");

            Console.Read();
        }
    }
}
