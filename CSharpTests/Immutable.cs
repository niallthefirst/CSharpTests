using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class Immutable
    {
        const string _name = "init";
        readonly int _price;//readonly can only be change from inside the constructor.

        public int Price
        {
            get { return _price; }
            //set { _price = value; }//readonly can only be change from inside the constructor.
        } 


        public Immutable(string name,int price)    {
            //_name = name; // <- Compilation error
            _price = price;//readonly can only be change from inside the constructor.
        }
    
    }

    class ImmutableAnonymous
    {
        internal static void Run()
        {
            var affine = new { A = 3, B = 4 };

            //affine.A = 3; // <- Compilation error. readonly
        }
    }
}
