namespace _5._Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string input)
        {
            int[] answer = [0, 0];
            int answerLength = answer[1] - answer[0] + 1;

            int oddLength, evenLength, distance;

            for (int index = 0; index < input.Length; index++)
            {
                oddLength = Expand(index, index, input);

                if (oddLength > answerLength)
                {
                    distance = oddLength / 2;

                    answer[0] = index - distance;
                    answer[1] = index + distance;

                    answerLength = oddLength;
                }

                evenLength = Expand(index, index + 1, input);

                if (evenLength > answerLength)
                {
                    distance = (evenLength / 2) - 1;

                    answer[0] = index - distance;
                    answer[1] = index + distance + 1;
                    
                    answerLength = evenLength;
                }
            }

            int i = answer[0];
            int j = answer[1];

            return input[i..(j + 1)];
        }

        public int Expand(int i, int j, string text)
        {
            int left = i;
            int right = j;

            for (; left >= 0 && right < text.Length; left--, right++)
            {
                if (text[left] != text[right])
                    break;
            }

            return right - left - 1;
        }
    }
}
