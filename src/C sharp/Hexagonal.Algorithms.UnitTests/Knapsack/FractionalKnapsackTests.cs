using Hexagonal.Algorithms.Knapsack;
using NUnit.Framework;
using System;
using System.Linq;

namespace Hexagonal.Algorithms.UnitTests.Knapsack
{
    public static class FractionalKnapsackTests
    {
        //TODO Need to implement
        [Test]
        public static void TakesHalf([Random(0, 1000, 100, Distinct = true)] int length)
        {
            var val = new[] { 135, 139, 149, 150, 156, 163, 173, 184, 192, 201, 210, 214, 221, 229, 240 };
            var wt = new[] { 7.0, 7.3, 7.7, 8.0, 8.2, 8.7, 9.0, 9.4, 9.8, 10.6, 11.0, 11.3, 11.5, 11.8, 12.0 };
            var items = Enumerable.Range(1, val.Count()).ToArray();

            var capacity = 75;

            Func<int, double> weightSelector = x => (int)(wt[Array.IndexOf(items, x)] * 10);
            Func<int, double> valueSelector = x => val[Array.IndexOf(items, x)];

            var expected = new[] { 1, 3, 5, 7, 8, 9, 14, 15 };


            //Act
            var solver = new FractionalKnapsack<int>();
            var actual = solver.Solve(items, capacity * 10, weightSelector, valueSelector);

            //Assert
            Assert.AreEqual(expected.OrderBy(x => x), actual.OrderBy(x => x));
        }
    }
}
