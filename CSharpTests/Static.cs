using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class Static
    {
        private static int staticMember;
        public Static()
        {
            _memberVar = 20;
        }

        public static int StaticMember
        {
            get { return Static.staticMember; }
            set { Static.staticMember = value; }
        }
        private int _memberVar;

        public int MemberVar
        {
            get { return _memberVar; }
            set { _memberVar = value; }
        }

        
        public static void ShowStatic()
        {
            Console.WriteLine("Static member : " + StaticMember);
        
        }
        public void ShowBoth()
        {
            Console.WriteLine("member var : " + MemberVar);
            Console.WriteLine("Static member : " + StaticMember);
        }


    
    }

    static class StaticClass
    {
        static StaticClass()
        {
            Init();
        }
        internal static void Init()
        {
            Console.WriteLine("Should be called only once, and when anything references the class");
        }
        internal static void DoNothing() { 

        }
    }
}
