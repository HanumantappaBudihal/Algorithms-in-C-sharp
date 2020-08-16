using System;
using System.Collections.Generic;
using System.Text;
using Hexagonal.Algorithms.Interfaces.Knapsack;

namespace Hexagonal.Algorithms.Knapsack
{
    public class FractionalKnapsack<T> : IKnapsackSolver<T>
    {
        /// <summary>
        /// TODO : Need to add the description
        /// </summary>
        /// <param name="items"></param>
        /// <param name="capacity"></param>
        /// <param name="weightSelector"></param>
        /// <param name="valueSelector"></param>
        /// <returns></returns>
        public T[] Solve(T[] items, double capacity, Func<T, double> weightSelector, Func<T, double> valueSelector)
        {
            //TODO Need to implement
            return null;
        }
    }
}
