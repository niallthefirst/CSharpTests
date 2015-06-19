using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class BaseClass
    {
    }

    sealed class SealedClass
    { 
    
    }


    abstract class AbstractClass
    {
        public virtual void OverrideMe()
        {
            Console.Write("Base Virtual");
        }

        public abstract void ImAbstract();
    }

    class DerivedClass : AbstractClass
    {
        public override void ImAbstract()
        {
            Console.WriteLine("Overriding the Abstract");
        }
    }
}
