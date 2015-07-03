using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class FuncAndActionDelegates
    {
        internal static void Run()
        { 
        
            //pass an Action into another method can call it.
            RunAction(); 

            //pass an Func into another method can call it.
            RunFunc();
        }
        static void RunAction()
        {
            Action<string> messageTarget = Console.WriteLine;
            messageTarget("Hello, World!");



            Action<String> print = new Action<String>(Print);//Action<String> must match Print(String s)
            List<String> names = new List<String> { "andrew", "nicole" };
            names.ForEach(print);
        }

        static void Print(String s)
        {
            Console.WriteLine(s);
        }


        static void RunFunc()
        {
            
            Func<string, string> messageTarget = PrintWithReturn;
            messageTarget("Hello, World!");

            UseFunc(messageTarget, "Use func a parameter");
        }

        static string PrintWithReturn(String s)
        {
            Console.WriteLine(s);
            return s;
        }

        static void UseFunc(Func<string, string> f, string message)
        {
            f(message);
        }

    }
}
