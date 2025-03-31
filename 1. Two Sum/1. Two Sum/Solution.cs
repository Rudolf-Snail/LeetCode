using System.Collections;

namespace _1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int length = nums.Length;
            int index1 = 0, index2 = 0;
            int currentNumber, currentNumber1, wantedNumber;

            Hashtable hashtable = new Hashtable(length);

            for (int index = 0; index < length; index++)
            {
                currentNumber = nums[index];
                hashtable[currentNumber] = index;
            }

            for (index1 = 0; index1 < length; index1++)
            {
                currentNumber1 = nums[index1];

                wantedNumber = target - currentNumber1;

#pragma warning disable CS8605 // Unboxing a possibly null value.
                if (!hashtable.ContainsKey(wantedNumber) || index1 == ( int ) hashtable[wantedNumber])
                    continue;

                index2 = ( int ) hashtable[wantedNumber];
#pragma warning restore CS8605 // Unboxing a possibly null value.

                return [index1, index2];
            }

            return [-1, -1]; // Returned if no correct result is found.
        }
    }
}
