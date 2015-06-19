using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpTests
{
    /// <summary>
    /// Pluralsight. http://www.pluralsight.com/training/player?author=jon-skeet&name=skeet-patterns-m1-singleton&mode=live&clip=0&course=csharp-design-strategies
    /// </summary>
    [TestClass()]
    class MyOneInstanceClass
    {
        private string _name;

        static readonly MyOneInstanceClass _instance = new MyOneInstanceClass();//threadsafe? yes. readonly, static.
        internal static MyOneInstanceClass Instance
        {
            get {
                //if (_instance == null)
                //    _instance = new SingleTon();//not thread safe. 2 threads could hit the _instance == null, at the same time and then create a new instance.

                Console.WriteLine("Getter.");
                return _instance; }
        }

        /// <summary>
        /// Not required. forces laziness
        /// </summary>
        static MyOneInstanceClass() {
            Console.WriteLine("Static Constructor."); 
        }

        private MyOneInstanceClass() {
            Console.WriteLine("Private Constructor.");
           _name = "init as singleton";
        }

       
        public void Print(string s)
        {
            Console.WriteLine(s + " , " +_name);
        }

    }
}
