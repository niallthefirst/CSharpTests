using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class Lambda
    {

        internal static void Select()
        {
            Console.WriteLine("\nSelect");
            // Input.
            string[] array =
                {
                    "dot",
                    "net",
                    "perls"
                };

            var result = array.Select(x => x);

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
            
        }

        internal static void SelectMany()
        {
            Console.WriteLine("\nSelectMany");
                // Input.
	            string[] array =
	            {
	                "dot",
	                "net",
	                "perls"
	            };

	            // Convert each string in the string array to a character array.
	            // ... Then combine those character arrays into one.
	            var result = array.SelectMany(element => element.ToCharArray());
                
	            // Display letters.
	            foreach (char letter in result)
	            {
	                Console.WriteLine(letter);
	            }
         }

        internal static void Where()
        {
            Console.WriteLine("\nWhere");
            // Input.
            string[] array =
                {
                    "dot",
                    "net",
                    "perls"
                };

            var result = array.Where(x => true);
            

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

        }

        internal static void SelectAndWhere()
        {
            Console.WriteLine("\nSelect and Where");
            // Input.
            string[] array =
                {
                    "dot",
                    "net",
                    "perls"
                };

            var result = array.Where(x => true).Select( x => x);

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

        }

        internal static void Any()
        {
            Console.WriteLine("\nAny");
            // Input.
            string[] array =
                {
                    "dot",
                    "net",
                    "perls"
                };

            bool result = array.Any(s => s != "a");

            Console.WriteLine(result);

        }

        internal static void Func()
        {
            Console.WriteLine("\nFunc");
            // Input.
            string[] array =
                {
                    "dot",
                    "net",
                    "perls"
                };

            // Convert each string in the string array to a character array.
            // ... Then combine those character arrays into one.

            Func<string, IEnumerable<char>> expression = element => element.ToCharArray();
            
            
            
            var result = array.SelectMany(expression);

            // Display letters.
            foreach (char letter in result)
            {
                Console.WriteLine(letter);
            }

        }

        

    }
}
