using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
















  
    public class A
    {
         public virtual string GetName()
         {
              return "A";
         }
     }

     public class B:A
     {
         public override string GetName()
         {
             return "B";
         }
     }

     public class C:B
     {
         public new string GetName()
         {
             return "C";
         }
     }

    public class OverrideTest
    {
         public static void Run()
         {
             A instance = new C();
             //Assert.AreEqual(instance.GetName(), "C");
             Console.WriteLine(instance.GetName());//prints B because its looking for the Override only.
         }
    }
}
