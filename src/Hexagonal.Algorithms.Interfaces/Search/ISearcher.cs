namespace Hexagonal.Algorithms.Interfaces.Search
{
    /// <summary>
    /// TODO : Need to figure out the implementing the IComparable and ISeacher issue
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISearcher<T>
    {
        //TODO : Need to implement the other functionalities
        int FindIndex(T[] inputArray, T itemToSeach);
    }
}
