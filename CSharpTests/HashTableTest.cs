using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class HashTableTest
    {

        internal static void Run()
        {
            Hashtable hashtable = new Hashtable();
            hashtable[1] = "One";
            hashtable[2] = "Two";
            hashtable[13] = "Thirteen";
            hashtable.Add("14", "fourteen");

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
        }
    }
}
