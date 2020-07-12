using NUnit.Framework;

namespace Hexagonal.Algorithms.Foundation
{
    public static class RandomHelper
    {
        /// <summary>
        /// TODO : Need to add the explaintion
        /// </summary>
        /// <param name="numberOfItems"></param>
        /// <returns></returns>
        public static (int[] correctArray, int[] testArray) GetArrays(int numberOfItems)
        {
            var testArray = new int[numberOfItems];
            var correctArray = new int[numberOfItems];

            for (var iterator = 0; iterator < numberOfItems; iterator++)
            {
                var value = TestContext.CurrentContext.Random.Next(1_000_000);
                testArray[iterator] = value;
                correctArray[iterator] = value;
            }

            return (correctArray, testArray);
        }

        /// <summary>
        /// TODO : Need to add the explaintion
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="maxLength"></param>
        /// <param name="equalLength"></param>
        /// <returns></returns>
        public static (string[] correctArray, string[] testArray) GetStringArrays(int limit, int maxLength, bool equalLength)
        {
            var testArray = new string[limit];
            var correctArray = new string[limit];
            var length = TestContext.CurrentContext.Random.Next(2, maxLength);

            for (var iterator = 0; iterator < limit; iterator++)
            {
                if (!equalLength)
                {
                    length = TestContext.CurrentContext.Random.Next(2, maxLength);
                }

                var chars = new char[length];
                for (var innerIterator = 0; innerIterator < length; innerIterator++)
                {
                    chars[innerIterator] = (char)TestContext.CurrentContext.Random.Next(97, 123);
                }

                var temp = new string(chars);
                testArray[iterator] = temp;
                correctArray[iterator] = temp;
            }

            return (correctArray, testArray);
        }
    }
}
