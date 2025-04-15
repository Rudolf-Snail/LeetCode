namespace _5._Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string input)
        {
            int n = input.Length;
            bool[,] dp = new bool[n, n];
            int[] answer = [0, 0];

            int i;

            for (i = 0; i < n; i++)
                dp[i, i] = true;

            int j;

            for (i = 0, j = 1; j < n; i++, j++)
            {
                if (input[i] == input[j])
                {
                    dp[i, j] = true;
                    answer = [i, j];
                }
            }

            for (int difference = 2; difference < n; difference++)
            {
                for (i = 0; i < n - difference; i++)
                {
                    j = i + difference;

                    if (input[i] == input[j] && dp[i + 1, j - 1])
                    {
                        dp[i, j] = true;
                        answer = [i, j];
                    }
                }
            }

            i = answer[0];
            j = answer[1];

            return input[i..(j + 1)];
        }
    }
}
