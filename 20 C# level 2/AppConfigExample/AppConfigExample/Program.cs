using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppConfigExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            string koko = ConfigurationManager.AppSettings["KokoConfig"];
            string myDBConnection = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            Console.WriteLine("\nConnection string = "+ connectionString);
            Console.WriteLine("\nKoko config = " + koko);
            Console.WriteLine("\n MyDBConnection = " + myDBConnection);

            Console.ReadKey();
        }
    }
}
