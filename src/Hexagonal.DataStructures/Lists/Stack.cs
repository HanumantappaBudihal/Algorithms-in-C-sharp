using System;
using System.Collections;
using System.Collections.Generic;

namespace Hexagonal.DataStructures.Lists
{
    /// <summary>
    /// LIFO -> Data structure which operate in LIFO manner.
    /// </summary>
    public class Stack<T> : IEnumerable<T> where T : IComparable<T>
    {
        private ArrayList<T> _collection { get; set; }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

