using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int index1 = 0, index2 = 0; 
            int currentNumber1, currentNumber2;
            int? result = null; 

            for (index1 = 0; index1 < nums.Length; index1++)
            {
                currentNumber1 = nums[index1];

                for (index2 = index1 + 1; index2 < nums.Length; index2++)
                {
                    currentNumber2 = nums[index2];

                    result = currentNumber1 + currentNumber2;

                    if (result == target)
                        return [index1, index2];
                }
            }

            return [-1, -1]; // Returned if no correct result is found.
        }
    }
}
