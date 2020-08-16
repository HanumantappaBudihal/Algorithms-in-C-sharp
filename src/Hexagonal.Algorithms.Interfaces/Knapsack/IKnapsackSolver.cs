using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.Algorithms.Interfaces.Knapsack
{
    public interface IKnapsackSolver<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="items">All items to choose from</param>
        /// <param name="capacity">How much weight we can take</param>
        /// <param name="weightSelector">Maps items to its weight</param>
        /// <param name="valueSelector">Maps item to its value</param>
        /// <returns>Items that were chosen</returns>
        T[] Solve(T[] items, double capacity, Func<T, double> weightSelector, Func<T, double> valueSelector);
    }
}
