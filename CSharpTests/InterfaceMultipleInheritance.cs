using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class InterfaceMultipleInheritance
    {
        internal static void Run()
        {
            /// New Derived class which is derived from MyTestBaseClass and MyTestBaseClass implements 2 interfaces.
            /// This is the workaround for multiple inheritance,its actually multiple interface implementation.
            MyDerivedClass derivedObj = new MyDerivedClass();
            ((Interface1)derivedObj).MyInterfaceFunction();
            ((Interface2)derivedObj).MyInterfaceFunction(); 
        }
        
    }


    /// <summary />
    /// Interface 1
    /// </summary />
    public interface Interface1
    {
        /// <summary />
        /// Function with the same name as Interface 2
        /// </summary />
        void MyInterfaceFunction();
    }

    /// <summary />
    /// Interface 2
    /// </summary />
    public interface Interface2
    {
        /// <summary />
        /// Function with the same name as Interface 1
        /// </summary />
        void MyInterfaceFunction();
    }

    /// <summary />
    /// MyTestBaseClass implements the two interfaces Interface1 and Interface2
    /// </summary />
    public class MyTestBaseClass : Interface1, Interface2
    {

       #region Interface1 Members

        void Interface1.MyInterfaceFunction()
        {
            Console.WriteLine("Frm MyInterface1 Function()");
            return;
        }

        #endregion

        #region Interface2 Members

        void Interface2.MyInterfaceFunction()
        {
            Console.WriteLine("Frm MyInterface2 Function()");
            return;
        }

        #endregion
    }

    /// <summary />
    /// New Derived class which is derived from MyTestBaseClass and MyTestBaseClass implements 2 interfaces.
    /// This is the workaround for multiple inheritance,its actually multiple interface implementation.
    /// </summary />
    public class MyDerivedClass : MyTestBaseClass
    {
        //No Functions Here....
    }
}
