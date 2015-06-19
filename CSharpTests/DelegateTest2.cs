﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{

    internal class DelegateTest2
    {
        internal static void Run()
        {
            //Note, this NotifyDelegate type is defined in the SaveToDatabase project
            NotifyDelegate nofityDelegate = new NotifyDelegate(NotifyIfComplete);

            SaveToDatabase sd = new SaveToDatabase();
            sd.Start(nofityDelegate);

        }

        //this is the method which will be delegated - the only thing it has in common with the NofityDelegate is that it takes 0 parameters and that it returns void. However, it is these 2 which are essential. It is really important to notice that it writes a variable which, due to no constructor, has not yet been called (so _notice is not initialized yet). 
        private static void NotifyIfComplete()
        {
            Console.WriteLine(_notice);
        }

        private static string _notice = "Notified";
    }


    public class SaveToDatabase
    {
        public void Start(NotifyDelegate nd)
        {
            Console.WriteLine("Yes, I shouldn't write to the console from here, it's just to demonstrate the code executed.");
            Console.WriteLine("SaveToDatabase Complete");
            Console.WriteLine(" ");
            nd.Invoke();
        }
    }
    public delegate void NotifyDelegate();
}

