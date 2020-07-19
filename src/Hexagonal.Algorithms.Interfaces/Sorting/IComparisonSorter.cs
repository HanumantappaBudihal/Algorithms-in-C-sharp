namespace Hexagonal.Algorithms.Interfaces.Sorting
{
    /// <summary>
    /// TODO : Explaintion 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IComparisonSorter<T>
    {
        /// <summary>
        /// TODO : Need to the code here
        /// </summary>
        /// <param name="inputArray"></param>
        void Sort(T[] inputArray);

        //TODO : need to Sort by descending
        //void SortByDescending(T[] inputArray)
    }
}
