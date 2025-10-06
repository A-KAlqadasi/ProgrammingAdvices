using System;


namespace Properties_Set_and_Get
{

    class clsEmployee
    {
        // fields
        private int _Id;
        private string _Name = string.Empty;


        public int ID
        {
            // Get is for reading field
            get
            {
                return _Id;
            }

            // Set is for writing field
            set
            {
                _Id = value;
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

            Employee.ID = 7;
            Employee.Name = "Abdulkareem Shawqi";

            Console.WriteLine("ID :{0}", Employee.ID);
            Console.WriteLine("Name :{0}", Employee.Name);

            Console.ReadKey();

        }
    }
}
