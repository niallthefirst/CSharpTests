using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    internal class Recursion
    {
        /// <summary>
        /// 8. returns 0, 1, 1, 2, 3, 5, 8
        /// </summary>
        /// <param name="end"></param>
        public static int Fibionacci(int end, int count, int previous)
        {
            int result = 0;
            //start at 0.
            //add the current number and the previous (if it exists).
            //stop at the end
            while (count <= end)
            {
                previous = count;
                result = previous + count;
                           

                
                Console.WriteLine(result);


                count = count + 1;
                Fibionacci(end, count, previous);

                return result;
            }

            return result;
        }
    }
}
