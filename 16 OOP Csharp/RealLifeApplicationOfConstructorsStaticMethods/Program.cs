using System;

class clsPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public short Age { get; set; }
    public string UserName { get; set; }

    public string Password { get; set; }

    public clsPerson(int id , string name , short age )
    {
        this.Id = id ;
        this.Name = name ;
        this.Age = age ;
    }

    public static clsPerson Find(int id)
    {
        // we simulate the resut for now , later on we will connect to DB
        if (id == 10)
            return new clsPerson(10, "Abdulkareem Shawqi", 20);
        else 
            return null;
    }

    public static clsPerson Find(string useName ,string password)
    {
        // we simulate the resut for now , later on we will connect to DB
        if (useName == "user1" && password == "p1234")
            return new clsPerson(10, "Abdulkareem Shawqi", 20);
        else 
            return null;    
    }


}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Person1 by ID");
            clsPerson Person1 = clsPerson.Find(10);

            if(Person1 != null)
            {
                Console.WriteLine($"ID:= {Person1.Id}");
                Console.WriteLine($"Name:= {Person1.Name}");
                Console.WriteLine($"Age:= {Person1.Age}");
            }
            else
            {
                Console.WriteLine("Could not find the person by given Id");
            }    

            clsPerson Person2 = clsPerson.Find("user1","p1234");
            Console.WriteLine("\n\nFinding Person2 by useName and password");
            
            if (Person2 != null)
            {
                Console.WriteLine($"ID:= {Person2.Id}");
                Console.WriteLine($"Name:= {Person2.Name}");
                Console.WriteLine($"Age:= {Person2.Age}");
            }
            else
            {
                Console.WriteLine("Could not find the person by given Id");
            }


    }
}

