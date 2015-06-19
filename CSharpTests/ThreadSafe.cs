using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTests
{

    /// <summary>
    /// 
    /// </summary>
    internal class ThreadSafe
    {
        static readonly object mymutex = new object();


        public static void Run(object s)
        {
            lock (mymutex)
            {
                Thread.Sleep(1000);
                Console.WriteLine(s + ", " + Environment.TickCount );
                
            }
        }
        
    }
}
