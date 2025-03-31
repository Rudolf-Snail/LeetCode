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
            Hashtable backupHashtableForIdenticalKeys = new Hashtable();

            for (int index = 0; index < length; index++)
            {
                currentNumber = nums[index];

                if (backupHashtableForIdenticalKeys.ContainsKey(currentNumber))
                    continue;
                else if (hashtable.ContainsKey(currentNumber))
                    backupHashtableForIdenticalKeys.Add(currentNumber, index);
                else
                    hashtable.Add(currentNumber, index);
            }

            for (index1 = 0; index1 < length; index1++)
            {
                currentNumber1 = nums[index1];

                wantedNumber = target - currentNumber1;

                if (!hashtable.ContainsKey(wantedNumber) || (currentNumber1 == wantedNumber && !backupHashtableForIdenticalKeys.Contains(wantedNumber)))
                    continue;
                else if (currentNumber1 == wantedNumber)
#pragma warning disable CS8605 // Unboxing a possibly null value.
                    index2 = ( int ) backupHashtableForIdenticalKeys[wantedNumber]; // Not a null value; compiler is wrong.
#pragma warning restore CS8605 // Unboxing a possibly null value.
                else
#pragma warning disable CS8605 // Unboxing a possibly null value.
                    index2 = ( int ) hashtable[wantedNumber]; // Not a null value; compiler is still wrong.
#pragma warning restore CS8605 // Unboxing a possibly null value.

                return [index1, index2];
            }

            return [-1, -1]; // Returned if no correct result is found.
        }
    }
}
