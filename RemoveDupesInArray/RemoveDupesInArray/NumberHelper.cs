using System.Linq;

namespace RemoveDupesInArray
{
    public static class NumberHelper
    {
        public static int RemoveDuplicates(int[] sortedArray)
        {
            if (sortedArray == null || sortedArray.Length == 0)
                return 0;

            int uniqueItemIndx = 1;

            for (int currIndx = 1; currIndx < sortedArray.Length; currIndx++)
            {
                // When current and previous values are same then keep moving.

                if (sortedArray[currIndx] == sortedArray[currIndx - 1])
                    continue;

                // When different value found, then capture it in unique place and move to next position.

                sortedArray[uniqueItemIndx] = sortedArray[currIndx];
                uniqueItemIndx++;
            }

            return uniqueItemIndx;
        }
    }
}