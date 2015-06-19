using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class StringTests
    {
        public static void AssignmentAsValueType()
        {
            var first = "first";
            var second = "second";

            first += " + 1";

            second = first;

            first += " + 2";//changing first does not change second i.e. a value type, second is not pointing to first, its a copy of its value.
                            //this is peculiar to string. It is technically a reference type stored on the heap but acts like a valuetype.
                            //https://visualstudiomagazine.com/Articles/2015/04/01/Strings-Value-Types-or-Reference-Types.aspx?Page=1
            second += " + 3";

            Console.WriteLine("First : " + first );
            Console.WriteLine("Second : " + second);
            
        }
        
    }
}
