using System;


namespace AbstractClass
{
    //Abstract class: is a restricted class that cannot be
    //used to create objects (to access it,
    //it must be inherited from another class).
    abstract class clsPerson
    {

      
        public string FistName { get; set; }
        public string LastName { get; set; }

        // Abstract method: can only be used in an abstract class,
        // and it does not have a body.
        // The body is provided by the derived class (inherited from).

        public abstract void Introduce();

        // In abstract class we can create normal methods also
        public void SayGoodBye()
        {
            Console.WriteLine("Goodbye!");
        }

    }

    class clsEmployee : clsPerson
    {
        public short EmployeeId { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FistName } {LastName}, and my employee" +
                $"id {EmployeeId}");
        }

       

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // You cannot create an object of an abstract class, you only inherit it
            //clsPerson Person1 = new clsPerson();

            clsEmployee Employee1 = new clsEmployee();

            Employee1.FistName = "Abdulkareem";
            Employee1.LastName = "Shawqi";
            Employee1.EmployeeId = 1234;
            Employee1.Introduce();
            Employee1.SayGoodBye();

            Console.ReadKey();

        }
    }
}
