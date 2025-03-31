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
            int[] sortedNums = new int[nums.Length];
            Array.Copy(nums, sortedNums, nums.Length);
            Array.Sort(sortedNums);

            int index1 = 0, index2 = 0; 
            int currentNumber1, currentNumber2, wantedNumber, originalIndex1, originalIndex2;

            for (index1 = 0; index1 < nums.Length; index1++)
            {
                currentNumber1 = sortedNums[index1];

                wantedNumber = target - currentNumber1;

                index2 = GetIndexOfWantedNumber(sortedNums, index1, wantedNumber);

                if (index2 >= 0)
                {
                    currentNumber2 = sortedNums[index2];

                    originalIndex1 = Array.IndexOf(nums, currentNumber1);
                    originalIndex2 = (currentNumber1 == currentNumber2)
                        ? Array.LastIndexOf(nums, sortedNums[index2])
                        : Array.IndexOf(nums, sortedNums[index2]);

                    return [originalIndex1, originalIndex2];

                }

            }

            return [-1, -1]; // Returned if no correct result is found.
        }

        private static int GetIndexOfWantedNumber(int[] sortedNums, int index1, int wantedNumber)
        {
            int index2;
            int indexAdjustment = index1 + 1;
            
            int[] restOfArray = sortedNums.Skip(indexAdjustment).ToArray();
            index2 = Array.BinarySearch(restOfArray, wantedNumber);

            if (index2 < 0)
                return index2;

            index2 += indexAdjustment;

            return index2;
        }
    }
}
