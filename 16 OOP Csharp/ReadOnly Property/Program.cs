using System;


namespace ReadOnly_Property
{

    class clsEmployee
    {
        // fields
        private int _Id = 6;
        private string _Name = string.Empty;

        // read only property we can assign value only in the constrctor and in the
        // private field

        public int ID
        {
            // Get is for reading field
            get
            {
                return _Id;
            }


        }

        public string Name
        {
            // Get is for reading field
            get
            {
                return _Name;
            }
            // Set is for writing field
            set
            {
                _Name = value;
            }

        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Employee = new clsEmployee();


            //Employee.ID = 7;
            Employee.Name = "Abdulkareem Shawqi";

            Console.WriteLine("ID :{0}", Employee.ID);
            Console.WriteLine("Name :{0}", Employee.Name);

            Console.ReadKey();

        }
    }
}
