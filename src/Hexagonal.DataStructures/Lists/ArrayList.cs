using System.Collections;
using System.Collections.Generic;
namespace Hexagonal.DataStructures.Lists
{
    //TODO 
    public class ArrayList<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
