using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    static class clsSettings
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


        //The static constructor is called only once during the execution
        //of the program. That's why when we call the constructor again,
        //only the regular constructor is called.

        //We can have only one static constructor in a class.
        //It cannot have any parameters or access modifiers.

        static clsSettings()
        {
            ProjectPath = @"C:\Projects\";
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

            
            Console.WriteLine(clsSettings.ProjectPath);


        }
    }
}
