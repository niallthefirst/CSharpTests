using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpTests
{
    internal class Recursion
    {
        /// <summary>
        /// 8. returns 0, 1, 1, 2, 3, 5, 8
        /// </summary>
        /// <param name="end"></param>
        public static void Fibionacci(int end, int count, int previous)
        {
            var result = new List<int>();
            DoFib(result, end);

            result.ForEach(Console.WriteLine);
                
        
        }
        private static void DoFib(List<int> result, int n)
        {
            
            int current = 0;
            int value = 0;
            while(current <= n)
            {
                if (current == 0)
                {
                    value = current;
                    result.Add(value);
                    current = 1;
                }
                else
                {
                    value = current;
                    result.Add(value);
                    current = value + current;
                }

            }
        }
    }
}
