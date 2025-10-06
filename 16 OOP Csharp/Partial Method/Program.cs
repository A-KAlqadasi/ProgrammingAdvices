using System;

namespace Partial_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the code of clsPerson Class is seperated in 2 files clsPerson1.cs and clsPersonPrinting.cs
            clsPerson person = new clsPerson();
            
            person.Age = 20;
            person.Birthday();

            Console.ReadKey();
        }
    }
}
