﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    /// <summary>
    /// Factorials are very simple things. 
    /// They're just products, indicated by an exclamation mark. 
    /// For instance, "four factorial" is written as "4!" and means 1×2×3×4 = 24. 
    /// In general, n! ("enn factorial") means the product of all the whole numbers from 1 to n; that is, n! = 1×2×3×...×n.
    /// </summary>
    class Factorial
    {
        public static void Run(int n)
        {
            var result = Fact(n);

            Console.Write(result);
        }
        private static int Fact(int n)
        {

            if (n == 0)//The condition that limites the method for calling itself
                return 1;
            return n * Fact(n - 1);
        }
    }
}
