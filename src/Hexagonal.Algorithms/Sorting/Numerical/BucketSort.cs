using Hexagonal.Algorithms.Interfaces.Sorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.Algorithms.Sorting.Numerical
{
    /// <summary>
    /// TODO :
    /// </summary>
    public class BucketSort<T> : INumericalSorter<T> where T : IComparable<T>
    {
        //TODO : Need to think about the different approch for implementation
        //TODO : How could we can implement the Bucker sort for all datatype, not only for Interger
        //Imp cases : 
        //1.Sort a large set of floating point numbers which are in range from 0.0 to 1.0 and are uniformly distributed across the range.
        //How do we sort the numbers efficiently?
        //2.Bucket Sort To Sort an Array with Negative Numbers
        public void Sort(T[] inputArray)
        {
            throw new NotImplementedException();
        }
    }
}
