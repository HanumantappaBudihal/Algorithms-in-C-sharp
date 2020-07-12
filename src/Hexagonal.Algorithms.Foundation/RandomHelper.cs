using NUnit.Framework;

namespace Hexagonal.Algorithms.Foundation
{
    public static class RandomHelper
    {
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

        public static (string[] correctArray, string[] testArray) GetStringArrays(int n, int maxLength, bool equalLength)
        {
            var testArr = new string[n];
            var correctArray = new string[n];
            var length = TestContext.CurrentContext.Random.Next(2, maxLength);

            for (var i = 0; i < n; i++)
            {
                if (!equalLength)
                {
                    length = TestContext.CurrentContext.Random.Next(2, maxLength);
                }

                var chars = new char[length];
                for (var j = 0; j < length; j++)
                {
                    chars[j] = (char)TestContext.CurrentContext.Random.Next(97, 123);
                }

                var t = new string(chars);
                testArr[i] = t;
                correctArray[i] = t;
            }

            return (correctArray, testArr);
        }
    }
}
