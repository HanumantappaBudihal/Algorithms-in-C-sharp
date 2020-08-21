using Hexagonal.Algorithms.Interfaces.Sorting;
using System;

namespace Hexagonal.Algorithms.Sorting.Comparison
{
    /// <summary>
    /// TODO : Need to explain
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MergeSort<T> : IComparisonSorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// TODO : Need to explain
        /// </summary>
        /// <param name="inputArray"></param>
        public void Sort(T[] inputArray)
        {
            if (inputArray is null)
                return;

            Sort(inputArray, 0, inputArray.Length - 1);
        }

        /// <summary>
        /// TODO :
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="leftIndex"></param>
        /// <param name="rightIndex"></param>
        private void Sort(T[] inputArray, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;

                Sort(inputArray, leftIndex, middleIndex);
                Sort(inputArray, middleIndex + 1, rightIndex);

                Merge(inputArray, leftIndex, middleIndex, rightIndex);
            }
        }

        /// <summary>
        /// TODO :
        /// </summary>
        /// <param name="input"></param>
        /// <param name="leftIndex"></param>
        /// <param name="middleIndex"></param>
        /// <param name="rightIndex"></param>
        private void Merge(T[] input, int leftIndex, int middleIndex, int rightIndex)
        {
            T[] leftArray = new T[middleIndex - leftIndex + 1];
            T[] rightArray = new T[rightIndex - middleIndex];

            Array.Copy(input, leftIndex, leftArray, 0, middleIndex - leftIndex + 1);
            Array.Copy(input, middleIndex + 1, rightArray, 0, rightIndex - middleIndex);

            int leftArrayIterator = 0;
            int rightArrayIterator = 0;

            for (int interator = leftIndex; interator < rightIndex + 1; interator++)
            {
                if (leftArrayIterator == leftArray.Length)
                {
                    input[interator] = rightArray[rightArrayIterator];
                    rightArrayIterator++;
                }
                else if (rightArrayIterator == rightArray.Length)
                {
                    input[interator] = leftArray[leftArrayIterator];
                    leftArrayIterator++;
                }
                else if (leftArray[leftArrayIterator].CompareTo(rightArray[rightArrayIterator]) <= 0)
                {
                    input[interator] = leftArray[leftArrayIterator];
                    leftArrayIterator++;
                }
                else
                {
                    input[interator] = rightArray[rightArrayIterator];
                    rightArrayIterator++;
                }
            }
        }
    }
}
