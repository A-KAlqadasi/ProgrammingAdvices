using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionWithCustomAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class MyCustomAttribute : Attribute
    {
        public string Description { get; }


        public MyCustomAttribute(string description)
        {
            Description = description;
        }
    }

    [MyCustom("This is a class attribute")]
    class MyClass
    {
        [MyCustom("This is a method attribute")]
        public void MyMethod()
        {
            // Method implementation
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            // Get the type of MyClass
            Type type = typeof(MyClass);
            

            // Get class-level attributes
            object[] classAttributes = type.GetCustomAttributes(typeof(MyCustomAttribute), false);
            foreach (MyCustomAttribute attribute in classAttributes)
            {
                Console.WriteLine($"Class Attribute: {attribute.Description}");
            }


            // Get method-level attributes
            MethodInfo methodInfo = type.GetMethod("MyMethod");
            object[] methodAttributes = methodInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);
            foreach (MyCustomAttribute attribute in methodAttributes)
            {
                Console.WriteLine($"Method Attribute: {attribute.Description}");
            }


        }
    }
}
