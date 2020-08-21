using Hexagonal.Algorithms.Foundation;
using Hexagonal.Algorithms.Interfaces.Search;
using System;

namespace Hexagonal.Algorithms.Search
{
    /// <summary>
    /// TODO : Explain
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinearSearcher<T> : ISearcher<T> where T : IComparable<T>
    {
        /// <summary>
        /// TODO : Explain
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="itemToSeach"></param>
        /// <returns></returns>
        public int FindIndex(T[] inputArray, T itemToSeach)
        {
            if (inputArray is null)
                return -1;

            for (int iterator = 0; iterator < inputArray.Length; iterator++)
            {
                if (inputArray[iterator].IsEqualTo<T>(itemToSeach))
                {
                    return iterator;
                }
            }

            return -1;
        }
    }
}
