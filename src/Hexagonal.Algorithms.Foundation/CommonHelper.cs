namespace Hexagonal.Algorithms.Foundation
{
    public static class CommonHelper
    {
        /// <summary>
        /// TODO : 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        public static void Swap<T>(this System.Collections.Generic.IList<T> list, int firstIndex, int secondIndex)
        {
            if (list.Count < 2 || firstIndex == secondIndex)
                return;

            var tempItem = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = tempItem;
        }
    }
}
