using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    /// <summary>
    /// http://www.dotnetperls.com/lazy
    /// </summary>
    internal class LazyInstantiation
    {
        int[] _array;
        public LazyInstantiation()
        {
            Console.WriteLine("LazyInstantiation()");
	        _array = new int[10];
        }
        private int Length
        {
	        get
	        {
	            return _array.Length;
	        }
        }

        internal static void Run()
        {
            // Create Lazy.
            Lazy<LazyInstantiation> lazy = new Lazy<LazyInstantiation>();//constructor not called.

            // Show that IsValueCreated is false.
            Console.WriteLine("IsValueCreated = {0}, constructor not called", lazy.IsValueCreated);

            // Get the Value.
            // ... This executes LazyInstantiation().
            LazyInstantiation test = lazy.Value;//constructor not called until Value is called on the object.

            // Show the IsValueCreated is true.
            Console.WriteLine("IsValueCreated = {0}, constructor has been called", lazy.IsValueCreated);

            // The object can be used.
            Console.WriteLine("Length = {0}", test.Length);
        }
    }
}
