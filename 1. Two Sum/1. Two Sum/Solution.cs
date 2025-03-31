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

            Dictionary<int, int> hashMap = new Dictionary<int, int>(length);

            for (index1 = 0; index1 < length; index1++)
            {
                currentNumber1 = nums[index1];

                wantedNumber = target - currentNumber1;

                if (hashMap.ContainsKey(wantedNumber))
                {
                    index2 = hashMap[wantedNumber];
                    
                    return [index1, index2];
                }

                hashMap[currentNumber1] = index1;
            }

            return Array.Empty<int>(); 
        }
    }
}
