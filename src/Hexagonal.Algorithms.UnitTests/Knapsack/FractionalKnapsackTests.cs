using Hexagonal.Algorithms.Knapsack;
using NUnit.Framework;
using System.Linq;

namespace Hexagonal.Algorithms.UnitTests.Knapsack
{
    public static class FractionalKnapsackTests
    {
        //TODO Need to implement
        [Test]
        public static void TakesHalf([Random(0, 1000, 100, Distinct = true)] int length)
        {
            //Arrange
            var solver = new FractionalKnapsack<int>();
            //TODO Need to implement 

            //Act
           // var result = solver.Solve(items, length, x => 1, y => 1);

            //Assert
            Assert.AreEqual(0,0);
        }
    }
}
