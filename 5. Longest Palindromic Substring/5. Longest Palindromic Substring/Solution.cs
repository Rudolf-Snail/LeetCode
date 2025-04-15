namespace _5._Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string input)
        {
            for (int length = input.Length; length >= 1 ; length--)
            {
                for (int start = 0; start <= input.Length - length; start++)
                {
                    if (IsPalindrome(start, start + length, input))
                        return input.Substring(start, length);
                }
            }

            return "";
        }

        public bool IsPalindrome(int startIndex, int endIndex, string text)
        {
            if (text == null)
                return false;
            else if (startIndex == endIndex)
                return true;

            int left = startIndex;
            int right = endIndex - 1; 

            for (; left < right; left++, right--)
            {
                if (text[left] != text[right])
                    return false;
            }

            return true;
        }
    }
}
