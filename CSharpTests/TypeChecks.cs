using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class TypeChecks
    {
        public static void IsA()
        {
            string result = string.Empty;

            var one = new TypeOne();
            var two = new TypeTwo();

            var check = one as IType;
            if (check != null)
                result = check.Print();
            check = two as IType;
            if (check != null)
                result = check.Print();


            Console.WriteLine(result);

            
        }

        public static void AsA()
        {
            string result = string.Empty;

            var one = new TypeOne();
            var two = new TypeTwo();

            if (one is IType)
            {
                
                result = (one as IType).Print();
            }
            if (two is IType)
            {
                result = (two as IType).Print();
            }

            Console.WriteLine(result);

        }
    }

    interface IType
    {
        string Print();
    }
    class TypeOne
    {
        
    }
    class TypeTwo : IType
    {
        public string Print()
        {
            return "Two";
        }
    }
}
