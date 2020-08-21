using Hexagonal.Algorithms.Foundation;
using Hexagonal.Algorithms.Sorting.Comparison;
using NUnit.Framework;
using System;

namespace Hexagonal.Algorithms.UnitTests.Sorting.Comparison
{
    /// <summary>
    /// TODO : Need to different data types to test the algorithm
    /// </summary>
    public static class BubbleSortTests
    {
        [Test]
        public static void ArraySorted([Random(0, 1000, 100, Distinct = true)] int limit)
        {
            // Arrange
            var sorter = new BubbleSort<int>();
            var (correctArray, testArray) = RandomHelper.GetArrays(limit);

            // Act
            sorter.Sort(testArray);
            Array.Sort(correctArray);

            // Assert
            Assert.AreEqual(testArray, correctArray);
        }
    }

    // TODO : Need to different data types to test the algorithm
}
