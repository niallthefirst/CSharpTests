using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    public delegate void MyDelegate();

    internal class DelegateTest3
    {
        internal static void Run()
        {
            string localVar = "local variable";
            
            MyDelegate myDelegateInstance = new MyDelegate(delegate { MyRealMethod(localVar); });//when called will take the value of the localVar at that time,as normal.


            localVar = "local variable reset";


            myDelegateInstance();

            
        }

        private static void MyRealMethod(string parameter2)
        {
            Console.WriteLine(parameter2);
        }


    }



   

}


