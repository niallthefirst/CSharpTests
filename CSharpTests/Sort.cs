using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class Sort
    {
        long[] _inputArray = new long[10];

        public long[] Data
        {
            get { return _inputArray; }
            
        }

        public Sort()
        {
            Random rnd = new Random();
            for (int i = 0; i < _inputArray.Length; i++)
            {
                _inputArray[i] = rnd.Next();
            }
        }
        private static void Swap(ref long valOne, ref long valTwo)
        {
            valOne = valOne + valTwo;
            valTwo = valOne - valTwo;
            valOne = valOne - valTwo;
        }

        private static void SwapWithTemp(ref long valOne, ref long valTwo)
        {
            long temp = valOne;
            valOne = valTwo;
            valTwo = temp;
        }


        public static void BubbleSort(long[] inputArray)
        {
            for (int iterator = 0; iterator < inputArray.Length; iterator++)
            {
                for (int index = 0; index < inputArray.Length - 1; index++)
                {
                    if (inputArray[index] > inputArray[index + 1])
                    {
                        Swap(ref inputArray[index], ref inputArray[index + 1]);
                    }
                }
            }
        }

        public static void QuickSort(long[] inputArray)
        {
            int left = 0;
            int right = inputArray.Length - 1;
            InternalQuickSort(inputArray, left, right);
        }

        ///<summary>
        /// Internal recursive sort algorithm for quick sort
        /// using divide and conquer. Sorting is done based on pivot
        ///</summary>
        ///<param name="inputArray"></param>
        ///<param name="left"></param>
        ///<param name="right"></param>
        private static void InternalQuickSort(long[] inputArray, int left, int right)
        {
            int pivotNewIndex = Partition(inputArray, left, right);
            long pivot = inputArray[(left + right) / 2];
            if (left < pivotNewIndex-1)
                InternalQuickSort(inputArray, left, pivotNewIndex - 1);
            if (pivotNewIndex < right)
                InternalQuickSort(inputArray, pivotNewIndex, right);
        }

        //This operation returns a new pivot everytime it is called recursively
        //and swaps the array elements based on pivot value comparison
        private static int Partition(long[] inputArray, int left, int right)
        {
            int i = left, j = right;
            long pivot = inputArray[(left + right) / 2];

            while (i <= j)
            {
                while (inputArray[i] < pivot)
                    i++;
                while (inputArray[j] < pivot)
                    j--;
                if (i <= j)
                {
                    SwapWithTemp(ref inputArray[i], ref inputArray[j]);
                    i++; j--;
                }
            }
            return i;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in _inputArray)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
