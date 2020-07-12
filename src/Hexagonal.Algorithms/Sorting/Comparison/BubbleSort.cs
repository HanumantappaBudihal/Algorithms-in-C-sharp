using Hexagonal.Algorithms.Interfaces.Sorting;
using System;
using System.Runtime.InteropServices;

namespace Hexagonal.Algorithms.Sorting.Comparison
{
    public class BubbleSort<T> : IComparisonSorter<T>
    {
        public void Sort(T[] inputArray)
        {
            for (int iterator = 0; iterator < inputArray.Length - 1; iterator++)
            {
                var wasChanged = false;

                for (int innerInterator = 0; innerInterator < inputArray.Length - iterator - 1; innerInterator++)
                {

                }
            }
        }
    }
}
