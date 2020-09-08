using System;

namespace Hexagonal.Algorithms.Knapsack
{
    //Find the cube root of given x where x>0
    class CubeRoot
    {
        // Find the cube root of the number using the Binary search approch
        // Run time complexity : O(log n)
        public static double GetCubeRoot(double number)
        {
            double low = 1.0;
            double high = number;

            while(Math.Abs(low-high)> 0.0000001)
            {
                double mid = (high + low) / 2.0;

                if ((mid * mid * mid) > number)
                    high = mid;
                else
                    low = mid;
            }

            return low;
        }
    }
}
