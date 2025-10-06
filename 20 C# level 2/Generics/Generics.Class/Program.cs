using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Class
{
    public class GenericsBox<T>
    {
        private T _content;
        public T Content
        {
            get
            {
                return _content;
            }

        }

        public GenericsBox(T value)
        {
            _content = value;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericsBox<int> genericInt = new GenericsBox<int>(20);

            Console.WriteLine($"Generic class content int: {genericInt.Content}");


            GenericsBox<string> genericString = new GenericsBox<string>("Abdulkareem");

            Console.WriteLine($"Generic class content string: {genericString.Content}");

            Console.ReadKey();
        }
    }
}

