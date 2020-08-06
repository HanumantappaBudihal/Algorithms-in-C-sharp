using Hexagonal.Algorithms.Foundation;
using Hexagonal.Algorithms.Interfaces.Search;
using System;

namespace Hexagonal.Algorithms.Search
{
    /// <summary>
    /// TODO : Need to add the explanitation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinarySearcher<T> : ISearcher<T> where T : IComparable<T>
    {
        /// <summary>
        /// TODO : Need to add the explanitation for method
        /// </summary>
        /// <param name="sortedData">input list in sorted orader</param>
        /// <param name="itemToSeach">Item need to check whether it is present in arry or not</param>
        /// <returns>Correct index value if item found in array otherwise -1</returns>
        public int FindIndex(T[] sortedData, T itemToSeach)
        {
            if (sortedData is null)
                return -1;

            var leftIndex = 0;
            var rightIndex = sortedData.Length - 1;

            while (leftIndex <= rightIndex)
            {
                var middleIndex = (leftIndex + rightIndex) / 2;

                if (itemToSeach.IsGreaterThan<T>(sortedData[middleIndex]))
                {
                    leftIndex = middleIndex + 1;
                    continue;
                }

                if (itemToSeach.IsLessThan<T>(sortedData[middleIndex]))
                {
                    rightIndex = middleIndex - 1;
                    continue;
                }

                return middleIndex;
            }

            return -1;
        }

        public int FindIndex(T[] sortedData, T itemToSearch,int leftIndex,int rightIndex)
        {
            if (leftIndex <= rightIndex)
            {
                int middleIndex = leftIndex + ((rightIndex - leftIndex) / 2);
               
                if (sortedData[middleIndex].Equals(itemToSearch))
                    return middleIndex;

                if(sortedData[middleIndex].IsLessThan(itemToSearch))
                {
                    return FindIndex(sortedData, itemToSearch, middleIndex = 1, rightIndex);
                }

                if (sortedData[middleIndex].IsGreaterThan(itemToSearch))
                {
                    return FindIndex(sortedData, itemToSearch, leftIndex, middleIndex - 1);
                }
            }

            return -1;
        }
    }
}
