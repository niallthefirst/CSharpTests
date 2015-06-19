﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
     
        /// <summary>
        /// The 'Strategy' abstract class
        /// </summary>
        abstract class SortStrategy
        {
            public abstract void Sort(List<string> list);
        }

        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        class QuickSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                list.Sort(); // Default is Quicksort
                Console.WriteLine("QuickSorted list ");
            }
        }

        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        class ShellSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                //list.ShellSort(); not-implemented
                Console.WriteLine("ShellSorted list ");
            }
        }

        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        class MergeSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                //list.MergeSort(); not-implemented
                Console.WriteLine("MergeSorted list ");
            }
        }

        /// <summary>
        /// The 'Context' class
        /// </summary>
        class SortedListStrategyPatternContext
        {
            private List<string> _list = new List<string>();
            private SortStrategy _sortstrategy;

            public void SetSortStrategy(SortStrategy sortstrategy)
            {
                this._sortstrategy = sortstrategy;
            }

            public void Add(string name)
            {
                _list.Add(name);
            }

            public void Sort()
            {
                _sortstrategy.Sort(_list);

                // Iterate over list and display results
                foreach (string name in _list)
                {
                    Console.WriteLine(" " + name);
                }
                Console.WriteLine();
            }
        }
    
}
