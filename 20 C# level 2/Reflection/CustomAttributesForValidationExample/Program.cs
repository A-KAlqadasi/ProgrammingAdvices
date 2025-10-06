using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]
public class RangeAttribute : Attribute
{
    public int Min { get; set; }
    public int Max { get; set; }

    public string ErrorMessage { get; set; }
    public RangeAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}

public class Person
{
    public string Name { get; set; }

    [Range(20,50,ErrorMessage ="Age must be between 20 - 50")]
    public int Age { get; set; }

    [Range(5, 10, ErrorMessage = "Experince must be between 5 - 10")]

    public int Experince { get; set; }


}


internal class Program
{
    static void Main(string[] args)
    {
        Person person = new Person { Age = 20, Name = "Abdulkareem Shawqi" ,Experince=1};

        if(ValidatePerson(person))
        {
            Console.WriteLine("Person is valid");
        }
        else
        {
            Console.WriteLine("Validation failed!");
        }


        Console.ReadKey();
    }
    static bool ValidatePerson(Person person)
    {
        Type type = typeof(Person);
        foreach (var property in type.GetProperties())
        {
            if (Attribute.IsDefined(property, typeof(RangeAttribute))) 
            { 
                var rangeAttribute = Attribute.GetCustomAttribute(property, typeof(RangeAttribute)) as RangeAttribute;
                var value = (int)property.GetValue(person);
                if (value < rangeAttribute.Min || value > rangeAttribute.Max)
                {
                    Console.WriteLine($"Validation failed for property '{property.Name}': {rangeAttribute.ErrorMessage}");
                    return false;
                }

            }
        }
        return true;
    }
}