using Hexagonal.Algorithms.Foundation;
using Hexagonal.Algorithms.Interfaces.Sorting;
using System;
namespace Hexagonal.Algorithms.Sorting.Comparison
{
    /// <summary>
    /// Selection sorting
    /// selecting sort is simple sequential search pattern
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SelectionSort<T> : IComparisonSorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorting is to finds the minimun element in un-sorted array and fix the position for that element
        /// It's follows the sequential search patterns
        /// Algorithm Type : Internal, in-place, stable,
        /// Time complexity: O(n^2),
        /// Space complexity: O(1),
        /// </summary>
        /// <param name="inputArray"> Array to sort</param>
        public void Sort(T[] inputArray)
        {
            //if input array is null, just return from method
            if (inputArray is null)
                return;

            for (var iterator = 0; iterator < inputArray.Length; iterator++)
            {
                var smallerElementIndex = iterator;// always assume that last element of sorted array is min of unsorted array

                for (var innerIterator = iterator + 1; innerIterator < inputArray.Length; innerIterator++)
                {
                    if (inputArray[smallerElementIndex].CompareTo(inputArray[innerIterator]) > 0)
                        smallerElementIndex = innerIterator; // re-asign the smallest element if current is smallest than mininum element
                }

                CommonHelper.Swap<T>(inputArray, iterator, smallerElementIndex);
            }
        }
    }
}
