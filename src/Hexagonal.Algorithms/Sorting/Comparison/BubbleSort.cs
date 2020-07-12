using Hexagonal.Algorithms.Foundation;
using Hexagonal.Algorithms.Interfaces.Sorting;
using System;

namespace Hexagonal.Algorithms.Sorting.Comparison
{
    /// <summary>
    /// TODO : Need to add the explaintion 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BubbleSort<T> : IComparisonSorter<T> where T : IComparable<T>
    {
        /// <summary>        
        ///Pseudocode :  
        ///     Given an array of N elements, Bubble Sort will:
        ///     1.Compare a pair of adjacent items (a, b),
        ///     2.Swap that pair if the items are out of order (in this case, when a > b),
        ///     3.Repeat Step 1 and 2 until we reach the end of array
        ///        (the last pair is the (N-2)-th and (N-1)-th items as we use 0-based indexing),
        ///     4.By now, the largest item will be at the last position.
        ///        We then reduce N by 1 and repeat Step 1 until we have N = 1.
        /// Reamks :
        ///     Sorts array using specified comparer,
        ///     internal, in-place, stable,
        ///     Time complexity: O(n^2),
        ///     Space complexity: O(1),
        ///     Where n - array length.
        /// </summary>
        /// <param name="inputArray">Input array to be sort</param>
        public void Sort(T[] inputArray)
        {
            for (int iterator = 0; iterator < inputArray.Length - 1; iterator++)
            {
                var wasChanged = false;

                for (int innerInterator = 0; innerInterator < inputArray.Length - iterator - 1; innerInterator++)
                {
                    if (inputArray[innerInterator].IsGreaterThan<T>(inputArray[innerInterator + 1]))
                    {
                        var temp = inputArray[innerInterator];
                        inputArray[innerInterator] = inputArray[innerInterator + 1];
                        inputArray[innerInterator + 1] = temp;

                        wasChanged = true;
                    }
                }

                if (!wasChanged)
                    break;
            }
        }
    }
}
