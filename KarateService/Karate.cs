namespace Karate
{
    public class ChopService
    {
        public int Chop(int targetValue, int[] valueArray)
        {
            var minIndex = 0;
            var maxIndex = valueArray.Length;
            var splitIndex = (maxIndex + minIndex) / 2;
            while (splitIndex != minIndex && splitIndex != maxIndex)
            {                
                if (valueArray[splitIndex] == targetValue)
                {
                return splitIndex;
                }
                else if (valueArray[splitIndex] < targetValue)
                {
                    minIndex = splitIndex;
                } 
                else 
                {
                    maxIndex = splitIndex;
                }

                splitIndex = (maxIndex + minIndex) / 2;
            }

            if (valueArray[splitIndex] == targetValue)
            {
                return splitIndex;
            }
            return -1;
        }
    }
}