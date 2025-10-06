using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
            string valueName = "YourValueName";

            try
            {
                string value = Registry.GetValue(keyPath, valueName,null) as string;


                if(value!= null)
                {
                    Console.WriteLine($"Your value data for {valueName} is: {value}");
                }
                else
                {
                    Console.WriteLine($"No value data found for {valueName}");
                }


            }
            catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadKey();

        }
    }
}
