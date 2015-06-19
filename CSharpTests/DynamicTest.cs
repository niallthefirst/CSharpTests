using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class DynamicTest
    {
        internal static void HandleException(ApplicationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        internal static void HandleException(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
