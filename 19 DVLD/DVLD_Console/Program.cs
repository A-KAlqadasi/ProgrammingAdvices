using System;
using System.Collections.Specialized;
using System.Data;

using DVLD_Business;

namespace DVLD_Console
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(clsUser.IsUserActive("user4"));

            Console.ReadKey();
        }
    }
}
