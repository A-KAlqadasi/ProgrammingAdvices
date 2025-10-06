using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Properties
{

    //A static class is basically the same as a non-static class,
    //but there is one difference: a static class cannot be instantiated.
    //In other words, you cannot use the new operator to create
    //a variable of the class type.


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

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // we cannot create an object of the static class
            //clsSettings Settings = new clsSettings();


            // read the static properties
            Console.WriteLine(clsSettings.DayNumber);
            Console.WriteLine(clsSettings.DayName);

            // write static property
            clsSettings.ProjectPath = @"C:\Projects\";
            Console.WriteLine(clsSettings.ProjectPath);

            Console.ReadKey();

        }
    }
}
