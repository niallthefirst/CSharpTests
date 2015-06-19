using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class ReferenceTypes
    {
        public static void Run()
        {
            List<string> fruits = new List<string> { "Apple", "Orange", "Banana" };
            Console.WriteLine("Original List");
            fruits.ForEach(fruit => Console.WriteLine(fruit));
            
            Console.WriteLine("After new List");
            CreateNewListOfVegetables(fruits);
            fruits.ForEach(fruit => Console.WriteLine(fruit));

            Console.WriteLine("After change List");
            ChangeListToVegetables(fruits);
            fruits.ForEach(fruit => Console.WriteLine(fruit));


            Console.WriteLine("After reference is replaced List");
            ReplaceReferenceToListOfVegetables(ref fruits);
            fruits.ForEach(fruit => Console.WriteLine(fruit));
        }
    
        /// <summary>
        /// create NEW list. new reference. original is not changed.
        /// </summary>
        /// <param name="list"></param>
        public static void CreateNewListOfVegetables(List<string> list)
        {
           list = new List<string> { "Carrot", "Asparagus", "Broccoli" };
        }

        

        /// <summary>
        /// use the original list.
        /// </summary>
        /// <param name="list"></param>
        public static void ChangeListToVegetables(List<string> list)
        {
            list.Clear();
            list.Add("Carrot");
            list.Add("Asparagus");
            list.Add("Broccoli");
        }


        /// <summary>
        /// Replace the reference with a new one. original is replaced.
        /// </summary>
        /// <param name="list"></param>
        public static void ReplaceReferenceToListOfVegetables(ref List<string> list)
        {
            list = new List<string> { "Potato", "Turnip", "Parsnip" };
        }
    }
}
