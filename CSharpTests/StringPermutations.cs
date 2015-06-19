using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    /// <summary>
    /// Combinations of n objects, taken r at a time. Remember, combination means that order doesn't matter. Repetition is not allowed.
    /// Combination = n! / [ r! (n-r)! ]
    /// n is the number of characters. r  is the lenght of the word. 
    /// e.g. 3 characters into 3 letter words => 3! / [3! (3-3)! ]  => 3 x 2 x 1 / [ 3 x 2 x 1 (0)!] = 6
    /// e.g. 4 characters into 4 letter words => 4! / [4! (4-4)! ]  => 4 x 3 x 2 x 1 / [ 4 x 3 x 2 x 1 (0)!] = 24
    /// </summary>
    public class StringPermutations
    {

        public static List<string> GetPermutations(string value)
        {
            List<string> result = null;


            //get all characters in string.
            char[] characters = value.ToCharArray();
            //create individual strings with combinations of all the characters. the new string should be the same lenght as the original.
            result = GenerateStringsWithCharacters(characters);

            return result;
        }

        /// <summary>
        /// create new strings with the character combinations.
        /// </summary>
        /// <param name="characters"></param>
        /// <returns></returns>
        private static List<string> GenerateStringsWithCharacters(char[] characters)
        {
            List<string> result = new List<string>();

            
            for (int count = 0; count < characters.Length; count++ )
            {
                var s = GenerateString(characters, count);
                result.Add(s);
            }
            

            return result;
        }
        /// <summary>
        /// if index is 0. then start at length -1 .
        /// if index is 1, then start at 1 and end at length - index
        /// </summary>
        /// <param name="characters"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static string GenerateString(char[] characters, int index)
        {
            StringBuilder sb = new StringBuilder();
            int end = index - index < 0 ? 0 : characters.Length -index;
            for (int count = index; count < end; count++)
            {
                var c = characters[count];
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
