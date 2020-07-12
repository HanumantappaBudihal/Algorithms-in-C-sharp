using Hexagonal.Algorithms.Foundation;
using Hexagonal.Algorithms.Sorting;
using NUnit.Framework;
using System;

namespace Hexagonal.Algorithms.UnitTests.Sorting.Comparison
{
    /// <summary>
    /// TODO : Need to different data types to test the algorithm
    /// </summary>
    public static class InsertionSortTests
    {
        [Test]
        public static void InsertionSort_RandowArrangedIntArray_SortedArray([Random(0, 1000, 100)] int limit)
        {
            // Arrange
            var sorter = new InsertionSort<int>();
            var (correctArray, testArray) = RandomHelper.GetArrays(limit);

            // Act
            sorter.Sort(testArray);
            Array.Sort(correctArray);

            // Assert
            Assert.AreEqual(testArray, correctArray);
        }

        [Test]
        public static void InsertionSort_NullArrayInput_NullArray()
        {
            // Arrange
            var sorter = new InsertionSort<int>();
            int[] inputArray = null;
            // Act
            sorter.Sort(inputArray);

            // Assert
            Assert.AreEqual(inputArray, null);
        }
    }
}
