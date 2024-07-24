using Karate;

namespace KarateServiceTests
{
    public class KarateTests
    {
        [TestCase(2, new int[] {1, 2, 3}, 1)]
        [TestCase(1, new int[] {1, 2, 3}, 0)]
        public void ChopArray(int valueToLookFor, int[] valueArray, int expectedIndex)
        {
            var chopService = new ChopService();
            var valueList = ConvertArrayToList(valueArray);

            var indexOfValue = chopService.Chop(valueToLookFor, valueList);

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