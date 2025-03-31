using System.Collections;

namespace _1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int length = nums.Length;
            int index1 = 0, index2 = 0;
            int currentNumber1, wantedNumber;

            Hashtable hashtable = new Hashtable(length);

            for (index1 = 0; index1 < length; index1++)
            {
                currentNumber1 = nums[index1];

                wantedNumber = target - currentNumber1;

                if (hashtable.ContainsKey(wantedNumber))
                {
#pragma warning disable CS8605 // Unboxing a possibly null value.
                    index2 = ( int ) hashtable[wantedNumber];
#pragma warning restore CS8605 // Unboxing a possibly null value.
                    
                    return [index1, index2];
                }

                hashtable[currentNumber1] = index1;
            }

            return Array.Empty<int>(); 
        }
    }
}
