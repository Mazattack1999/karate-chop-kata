using Karate;

namespace KarateServiceTests
{
    public class KarateTests
    {
        public void ChopArray(int valueToLookFor, int[] valueArray)
        {
            var chopService = new ChopService();
            var valueList = ConvertArrayToList(valueArray);

            var indexOfValue = chopService.Chop(valueToLookFor, valueList);
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