using System;
using System.Net.Http.Headers;

namespace AddOneToArray
{
    public static class ArrayHelper
    {
        /// <summary>
        /// The problem is, an array [1, 4, 6] = some number 146. Add one to the array to become 147 or [1, 4, 7].
        /// Confirmation questions:
        /// 1. Is the array ever empty? - No
        /// 2. Is the array comprised of nums 0 - 9? - Yes 
        /// Cases:
        ///     easy case: [1, 4, 6] -> [1, 4, 7]
        ///     hard case: [1, 5, 9] -> [1, 6, 0]
        ///     hardest case: [9, 9, 9] -> [1, 0, 0, 0]
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] AddOneToArray(int[] nums)
        {
            // copy the given array
            var result = nums;

            var carry = 1;

            for (var i = nums.Length - 1; i >= 0; i--)
            {
                var sum = nums[i] + carry;

                // if the sum is 10, carry stays 1, else it's 0 and continue
                carry = sum == 10 ? 1 : 0;

                // place the 0 if carry = 1, else we place the number + 1
                result[i] = sum % 10;

            }

            if (carry == 1)
            {
                result = new int[nums.Length + 1];
                result[0] = 1;
            }

            return result;
        }
    }
}