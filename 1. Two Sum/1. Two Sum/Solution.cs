using System.Collections;

namespace _1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int length = nums.Length;
            int index = 1;
            int currentNumber, wantedNumber;

            Dictionary<int, int> hashMap = new Dictionary<int, int>(length);
            hashMap[nums[0]] = 0;

            for (; index < length; index++)
            {
                currentNumber = nums[index];

                wantedNumber = target - currentNumber;

                if (hashMap.ContainsKey(wantedNumber))
                    return [index, hashMap[wantedNumber]];

                hashMap[currentNumber] = index;
            }

            return Array.Empty<int>(); 
        }
    }
}
