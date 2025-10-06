using System;

namespace Partial_Method
{
    public partial class clsPerson
    {
        public int Age { get; set; }
        //A partial class may contain a partial method.
        //One part of the class contains the signature of the method.
        //An optional implementation may be defined in the same part or another part.
        
        //If the implementation is not supplied,
        //then the method and all calls are removed at compile time.
       
        // its return time implicitly private and it cannot be virtual
        // so it cannot be used As public API
         partial void PrintAge();

        

        public void Birthday()
        {
            Age++;
            // if PrintAge is implemented it will be called otherwise it will be ignored
            PrintAge();
        }

    }
}
