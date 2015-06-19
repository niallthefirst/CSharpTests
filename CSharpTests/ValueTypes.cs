using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class ValueTypes
    {
        public int Value{ get;set;}
        public ValueTypes(int value)
        {
            Value = value;
        }

        internal static void PassByValue(int value)
        {
            value += 10;
        }

        internal static void PassByRef(ref int value)
        {
            value += 10;
        }

        internal static void PassReferenceType(ValueTypes valueTypesObj)
        {
            valueTypesObj.Value = 2;
        }
    }
}
