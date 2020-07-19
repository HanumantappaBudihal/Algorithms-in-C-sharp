using Hexagonal.Algorithms.Foundation;
using Hexagonal.Algorithms.Interfaces.Sorting;
using System;

namespace Hexagonal.Algorithms.Sorting.Comparison
{
    /// <summary>
    /// Quick Sort
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QuickSort<T> : IComparisonSorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts array using quick sort algorithms
        /// Algorith Type : Partition algorithm, in-place, internal 
        /// Time complexity average: O(n log(n)),
        /// Time complexity worst: O(n^2),
        /// Space complexity: O(log(n)),
        /// </summary>
        /// <param name="inputArray"></param>
        public void Sort(T[] inputArray)
        {
            if (inputArray is null)
                return;

            //using recursion
            Sort(inputArray, 0, inputArray.Length - 1);
        }

        /// <summary>
        /// The main function that implements QuickSort()           
        /// </summary>
        /// <param name="inputArray">Array to be sorted,</param>
        /// <param name="leftIndex">Starting index</param>
        /// <param name="rightIndex">Ending index </param>
        private void Sort(T[] inputArray, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
                return;

            var partitionIndex = Partition(inputArray, leftIndex, rightIndex);
            // Recursively sort elements before 
            // partition and after partition 
            Sort(inputArray, leftIndex, partitionIndex);
            Sort(inputArray, partitionIndex + 1, rightIndex);
        }

        /// <summary>
        /// This function takes last element as pivot, places the pivot element at it's correct
        /// position is sorted array , and places all smaller to left of pivot and all greater to 
        /// right side of the pivot element
        /// </summary>
        /// <param name="inputArray">arrya</param>
        /// <param name="leftIndex"> Starting index of partition</param>
        /// <param name="rightIndex">Ending index of partition</param>
        /// <returns></returns>
        private int Partition(T[] inputArray, int leftIndex, int rightIndex)
        {
            var pivotElement = inputArray[rightIndex];
            var smallerElementIndex = (leftIndex - 1); // index of smaller element

            for (int iterator = 0; iterator < rightIndex; iterator++)
            {
                //If current element is smaller than the pivot element
                //move the smaller element to left side of pivot ( exchange the element)
                if (inputArray[iterator].CompareTo(pivotElement) < 0)
                {
                    smallerElementIndex++;

                    //Swap inputArray[smallerElementIndex] to inputArray[rightIndex]
                    CommonHelper.Swap<T>(inputArray, smallerElementIndex, iterator);
                }
            }

            // Swap inputArray[smallerElementIndex+1] and inputArray[rightIndex] ( or Pivot element)
            CommonHelper.Swap<T>(inputArray, smallerElementIndex + 1, rightIndex);

            // Partition Index
            return smallerElementIndex + 1;
        }
    }
}
