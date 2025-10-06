using System;

namespace Interface
{
    //an interface is similar to abstract class.
    //However, unlike abstract classes, all methods of an interface
    //are fully abstract (method without body).

    //We cannot use access modifiers inside an interface
    //Interfaces can contain properties and methods, but not fields/variables
    //Interface members are by default abstract and public

    // An interface cannot contain a constructor
    // (as it cannot be used to create objects)

    public interface IPerson
    {
        //An interface doesn't allow fields.
        //public string Name;

        

        string FirstName { get; set; }
        string LastName { get; set; }

        void Introduce();
        void Print();
        string To_String();

    }

    public abstract class clsPerson :IPerson
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void Introduce();

        public void Print()
        {
            Console.WriteLine("Hi this is print function..."); 
        }

        public string To_String()
        {
            return "This is the complete string....";
        }

        public void SendEmail()
        {
            Console.WriteLine("Email sent..");
        }

    }





    internal class Program
    {
        static void Main(string[] args)
        {
            //Like abstract classes, interfaces cannot be used to create objects.
            //IPerson Person = new IPerson();

            Console.ReadKey();

        }
    }
}
