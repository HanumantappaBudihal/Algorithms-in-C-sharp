using System;
using System.Collections;
using System.Collections.Generic;

namespace Hexagonal.DataStructures.Lists
{
    public class Queue<T> : IEnumerable<T> where T : IComparable<T>
    {
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
