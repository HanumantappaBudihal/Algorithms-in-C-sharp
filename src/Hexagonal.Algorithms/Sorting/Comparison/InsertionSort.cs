using Hexagonal.Algorithms.Foundation;
using Hexagonal.Algorithms.Interfaces.Sorting;
using System;

namespace Hexagonal.Algorithms.Sorting
{
    /// <summary>
    /// This class implements the Insertion sorting algortihms
    /// mark first element as sorted
    ///     for each unsorted element X
    ///         'extract' the element X as Key
    ///         for j = lastSortedIndex down to 0
    ///           if current element j > X
    ///             move sorted element to the right by 1
    ///           break loop and insert X here 
    ///</summary>
    ///<typeparam name="T">Type of array elements</typeparam>

    public class InsertionSort<T> : IComparisonSorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Time complexity : Best case (sorted array) : O(n) , Avg Case : O(n^2) , Worst Case : O(n^2)
        /// Space complexity : O(1)
        /// Remarks : Stable , Comparion and In-place type sorting algoritm 
        /// </summary>
        /// <param name="inputArray">array elememts to sort</param>
        public void Sort(T[] inputArray)
        {
            //if input array is null, just return from the method
            if (inputArray is null)
                return;

            for (var iterator = 1; iterator < inputArray.Length; iterator++)
            {
                var key = inputArray[iterator];
                var innerIterator = iterator - 1;

                while (innerIterator >= 0 && inputArray[innerIterator].IsGreaterThan<T>(key))
                {
                    inputArray[innerIterator + 1] = inputArray[innerIterator];
                    innerIterator = innerIterator - 1;
                }

                inputArray[innerIterator + 1] = key;
            }
        }
    }
}
