using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Method
{
    public partial class clsPerson
    {
       
        partial void PrintAge()
        {
            
            Console.WriteLine($"Your age is {Age}");

        }



    }
}
