using Karate;

namespace KarateServiceTests
{
    public class KarateTests
    {
        [TestCase(1, new int[] {1, 2, 3, 4, 5, 6}, 0)]
        [TestCase(2, new int[] {1, 2, 3, 4, 5, 6}, 1)]
        [TestCase(6, new int[] {1, 2, 3, 4, 5, 6}, 5)]
        [TestCase(7, new int[] {1, 2, 3, 4, 5, 6}, -1)]
        [TestCase(1, new int[] {1, 2}, 0)]
        [TestCase(2, new int[] {1, 2}, 1)]
        [TestCase(2, new int[] {1, 2, 3}, 1)]
        [TestCase(3, new int[] {1, 2, 3}, 2)]
        public void ChopArray(int valueToLookFor, int[] valueArray, int expectedIndex)
        {
            var chopService = new ChopService();

            var indexOfValue = chopService.Chop(valueToLookFor, valueArray);

            Assert.That(indexOfValue, Is.EqualTo(expectedIndex));
        }

        private static List<int> ConvertArrayToList(int[] array) 
        {
            var list = new List<int>();
            foreach (var value in array)
            {
                list.Add(value);
            }
            return list;
        }
    }
}