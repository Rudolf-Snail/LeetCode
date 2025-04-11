namespace _4._Median_of_Two_Sorted_Arrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length, length2 = nums2.Length, combinedLength = length1 + length2;
            bool isEven = combinedLength % 2 == 0;
            int medianNumberIndex = isEven ? (combinedLength / 2) - 1 : combinedLength / 2;

            int index = 0, index1 = 0, index2 = 0;
            int currentNumber = int.MinValue, currentNumber1 = int.MinValue, currentNumber2 = int.MinValue;

            for (; index <= medianNumberIndex; index++)
                currentNumber = GetCurrentLowestNumber(nums1, nums2, length1, length2, ref index1, ref index2, 
                                                       currentNumber, ref currentNumber1, ref currentNumber2);

            double median = currentNumber;

            if (isEven)
            {
                int secondNumber = GetCurrentLowestNumber(nums1, nums2, length1, length2, ref index1, ref index2, 
                                                          currentNumber, ref currentNumber1, ref currentNumber2);
                median = (currentNumber + secondNumber) / ( double ) 2;
            }

            return median;
        }

        private static int GetCurrentLowestNumber(int[] nums1, int[] nums2, int length1, int length2, ref int index1, ref int index2, int currentNumber, ref int currentNumber1, ref int currentNumber2)
        {
            if (index1 < length1 && index2 < length2)
            {
                FindCurrentLowestNumber(nums1, nums2, ref index1, ref index2, out currentNumber, out currentNumber1, out currentNumber2);
            }
            else if (index1 < length1)
            {
                ProcessLowestNumber(nums1, ref index1, out currentNumber, out currentNumber1);
            }
            else
            {
                ProcessLowestNumber(nums2, ref index2, out currentNumber, out currentNumber2);
            }

            return currentNumber;
        }

        private static void FindCurrentLowestNumber(int[] nums1, int[] nums2, ref int index1, ref int index2, out int currentNumber, out int currentNumber1, out int currentNumber2)
        {
            currentNumber1 = nums1[index1];
            currentNumber2 = nums2[index2];

            if (currentNumber1 <= currentNumber2)
            {
                currentNumber = currentNumber1;
                index1++;
            }
            else
            {
                currentNumber = currentNumber2;
                index2++;
            }
        }

        private static void ProcessLowestNumber(int[] nums, ref int index, out int currentNumber, out int currentArrayNumber)
        {
            currentArrayNumber = nums[index];
            currentNumber = currentArrayNumber;
            index++;
        }
    }
}
