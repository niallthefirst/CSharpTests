using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class Numbers
    {
        public static void Print()
        {
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;
            Console.WriteLine("float: {0} double: {1} decimal: {2}", flt, dbl, dcm);
        }
    }
}
