using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class Increment
    {
        public static void Int()
        {
            int i = 10;
            int j = 20;
            i = i++;//post. results in 10.
            j = ++j;//pre

            Console.WriteLine(i + " : " + j);
        }
    }
}
