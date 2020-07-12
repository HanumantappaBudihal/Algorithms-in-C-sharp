using Hexagonal.Algorithms.Search;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Linq;

namespace Hexagonal.Algorithms.UnitTests.Search
{
    /// <summary>
    /// TODO : Explanation
    /// </summary>
    public static class LinearSearcher
    {
        [Test]
        public static void FindIndex_ArrayEmpty_MinusOneReturned([Random(100)] int itemToSearch)
        {
            // Arrange
            var searcher = new LinearSearcher<int>();
            var inputArray = new int[0];
            // Act
            var actualIndex = searcher.FindIndex(inputArray, itemToSearch);

            // Assert
            Assert.AreEqual(-1, actualIndex);
        }

        [Test]
        public static void FindIndex_NullArray_MinusOneReturned([Random(100)] int itemToSearch)
        {
            //Arrange
            var searcher = new LinearSearcher<int>();
            var randomizer = Randomizer.CreateRandomizer();
            int[] inputArray = null;

            //Act
            var actualIndex = searcher.FindIndex(inputArray, itemToSearch);

            //Assert
            Assert.AreEqual(-1, actualIndex);
        }
        
        [Test]
        public static void FindIndex_CorrectItemInList_CorrectIndex([Random(1, 1000, 100)] int maxLimit)
        {
            //Arrange
            var searcher = new LinearSearcher<int>();
            var randomizer = Randomizer.CreateRandomizer();
            var inputArray = Enumerable.Range(0, maxLimit).Select(t => randomizer.Next(0, 1000)).OrderBy(t => t).ToArray();
            var selectedIndex = randomizer.Next(0, maxLimit);

            //Act
            var actualIndex = searcher.FindIndex(inputArray, inputArray[selectedIndex]);

            //Assert
            Assert.AreEqual(inputArray[selectedIndex], inputArray[actualIndex]);
        }

        [Test]
        public static void FindIndex_MissingItem_MinusOneRetured([Random(0, 1000, 100)] int maxLimit, [Random(-100, 1100, 10)] int missingItem)
        {
            // Arrange
            var searcher = new LinearSearcher<int>();
            var random = Randomizer.CreateRandomizer();
            var inputArray = Enumerable.Range(0, maxLimit).Select(x => random.Next(0, 1000)).Where(x => x != missingItem).OrderBy(x => x).ToArray();

            // Act
            var actualIndex = searcher.FindIndex(inputArray, missingItem);

            // Assert
            Assert.AreEqual(-1, actualIndex);
        }
    }
}