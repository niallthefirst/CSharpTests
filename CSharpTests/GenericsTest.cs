using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class GenericsTest
    {
        internal static void Run()
        {
            //call 3 methods with the same name but different types. The type should be preserved.
            GenericsTest.Call(111);
            GenericsTest.Call(222L);
            GenericsTest.Call(333.333M);
        }

        private static void Call<T>(T value)
        {
            Console.WriteLine(value + "  " + value.GetType());
        }

        
    }
}
