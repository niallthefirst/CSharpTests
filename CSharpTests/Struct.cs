using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    struct ExampleStruct
    {
        public int[] _member1;
        public int[] _member2;
        public ExampleStruct(int[] value1, int[] value2)
        {
            this._member1 = value1;
            this._member2 = value2;
        }
    }

    class ExampleClass
    {
        public int[] _member1;
        public int[] _member2;
        public ExampleClass(int[] value1, int[] value2)
        {
            this._member1 = value1;
            this._member2 = value2;
        }
    }
    class StructTest
    {
        static int GetStructValue(ExampleStruct example)
        {
            return example._member1[0];
        }

        static int GetClassValue(ExampleClass example)
        {
            return example._member1[0];
        }

        public static void Run()
        {
            //
            // Create a new array with value 5.
            //
            int[] array1 = new int[1];
            array1[0] = 5;
            Console.WriteLine("--- Array element assigned ---");

            //
            // Create new struct and class.
            //
            ExampleStruct structInstance = new ExampleStruct(array1, array1);
            ExampleClass classInstance = new ExampleClass(array1, array1);

            //
            // Use struct and then class in method as parameters.
            //
            int structInstanceInnerValue = GetStructValue(structInstance);
            Console.WriteLine(structInstanceInnerValue);

            int classInstanceInnerValue = GetClassValue(classInstance);
            Console.WriteLine(classInstanceInnerValue);

            //
            // Change the value of the array element.
            //
            array1[0] = 10;
            Console.WriteLine("--- Array element changed ---");

            int structInstanceInnerValue2 = GetStructValue(structInstance);
            Console.WriteLine(structInstanceInnerValue2);

            int classInstanceInnerValue2 = GetClassValue(classInstance);
            Console.WriteLine(classInstanceInnerValue2);
        }
    }
}
