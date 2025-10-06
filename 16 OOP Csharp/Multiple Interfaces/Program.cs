using System;


namespace Multiple_Interfaces
{

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

    public interface IComunicate
    {
        void PhoneCall();
        void SendSMS(string Title , string Message);
        void SendEmail(string Title, string Message);
        void SendFax(string Title, string Message);

    }

    public abstract class clsPerson : IPerson, IComunicate
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

        public void SendEmail(string Title, string Message)
        {
            Console.WriteLine("Email sent :-)");
        }

        public void PhoneCall()
        {
            Console.WriteLine("Calling Phone... :-)");
        }

        public void SendSMS(string Title , string Message)
        {
            Console.WriteLine("SMS Send :-)");
        }

        public void SendFax(string Title , string Message)
        {
            Console.WriteLine("Fax Send :-)");
        }


    }

    class clsEmployee : clsPerson
    {
        public short EmployeeId { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and my employee" +
                $"id {EmployeeId}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Like abstract classes, interfaces cannot be used to create objects.
            //IPerson Person = new IPerson();

            clsEmployee Employee1 = new clsEmployee();

            Employee1.FirstName = "Abdulkareem";
            Employee1.LastName = "Shawqi";
            Employee1.EmployeeId = 1234;
            Employee1.Introduce();

            Employee1.PhoneCall();
            Employee1.SendEmail("title","body");
            Employee1.SendSMS("title", "body");
            Employee1.SendFax("title", "body");


            Console.ReadKey();
        }
    }
}
