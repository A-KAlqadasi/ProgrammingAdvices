using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableDataTypeExample
{
    /*
        Nullable<int> and int? are both used to declare nullable integers.
        HasValue property is used to check if the nullable value has a value.
        The null-coalescing operator (??) is used to provide a default value if the nullable value is null.
        The null-conditional operator (?.) is used to access a property or method only if the nullable value is not null.
        Using int? is more common and convenient for declaring nullable integers in C#.
        You can apply the concept of nullable types to other value types as well,
        such as DateTime?, float?, etc., depending on your requirements.
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a nullable int using Nullable<T>
            Nullable<int> nullableInt1 = 1;

            int? nullableInt2 = null;

            if(nullableInt1.HasValue)
            {
                Console.WriteLine("nullable1 has value"+nullableInt1.Value);
            }
            else
            {
                Console.WriteLine("nullable1 is null");
            }

            if (nullableInt2.HasValue)
            {
                Console.WriteLine("nullable2 has value" + nullableInt2.Value);

            }
            else
            {
                Console.WriteLine("nullable2 is null");
            }

            //sing null-coalescing operator
            int result = nullableInt1 ?? 0;
            Console.WriteLine("Using null-coalescing operator: " + result);

            // Using the null-conditional operator
            string value = nullableInt1?.ToString();
            Console.WriteLine("String representation: " + (value ?? "null"));

            Console.ReadKey();
        }
    }
}
