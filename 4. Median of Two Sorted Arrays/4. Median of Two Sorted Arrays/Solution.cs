namespace _4._Median_of_Two_Sorted_Arrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] A, int[] B)
        {
            int aLength = A.Length;
            int bLength = B.Length;

            return (aLength + bLength) % 2 == 1
                ?    NthSmallestElement((aLength + bLength) / 2, A, B)
                : (NthSmallestElement((aLength + bLength) / 2, A, B) + NthSmallestElement(((aLength + bLength) / 2) - 1, A, B)) / ( double ) 2;
        }

        public static int NthSmallestElement(int n, int[] A, int[] B)
        {
            int aStart = 0, aEnd = A.Length - 1;
            int bStart = 0, bEnd = B.Length - 1;

            int aIndex, aValue, bIndex, bValue;

            while (true)
            {
                if (aEnd < aStart)
                    return B[n - aStart];
                if (bEnd < bStart)
                    return A[n - bStart];

                aIndex = (aStart + aEnd) / 2;
                bIndex = (bStart + bEnd) / 2;
                aValue = A[aIndex];
                bValue = B[bIndex];

                if (aIndex + bIndex < n)
                {
                    if (aValue < bValue)
                        aStart = aIndex + 1;
                    else
                        bStart = bIndex + 1;
                }
                else
                {
                    if (bValue < aValue)
                        aEnd = aIndex - 1;
                    else
                        bEnd = bIndex - 1;
                }
            }
        }
    }
}
