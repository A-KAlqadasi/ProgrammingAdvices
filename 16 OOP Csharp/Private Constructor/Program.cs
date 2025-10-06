using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    // if we declare the class as static we cannot create constructor
     class clsSettings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }

        // we have to way to prevent class of creating constructor 
        // one of them declaring constructor as private 
        // and the second way declaring the class as static

        private clsSettings()
        {

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // You cannot create and object here because class has private constructor
            //clsSettings Settings = new clsSettings();


            // Read the static properties
            Console.WriteLine(clsSettings.DayNumber);
            Console.WriteLine(clsSettings.DayName);

            clsSettings.ProjectPath = @"C:\Projecs\";
            Console.WriteLine(clsSettings.ProjectPath);


        }
    }
}
