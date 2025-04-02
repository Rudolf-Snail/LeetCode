namespace _3._Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int inputLength = s.Length;
            Dictionary<char, int> letters = new(inputLength);

            string longestSubstring = "";
            string currentSubstring = "";
            char currentCharacter;

            for (int index = 0; index < inputLength; index++)
            {
                currentCharacter = s[index];

                if (!letters.ContainsKey(currentCharacter))
                {
                    currentSubstring += currentCharacter;
                    letters.Add(currentCharacter, currentSubstring.Length - 1);

                    continue;
                }
                else
                {
                    if (currentSubstring.Length > longestSubstring.Length)
                        longestSubstring = currentSubstring;

                    currentSubstring = (letters[currentCharacter] == currentSubstring.Length - 1) ?
                                        currentCharacter.ToString() : 
                                        currentSubstring.Substring(letters[currentCharacter] + 1) + currentCharacter;

                    letters.Clear();

                    for (int substringIndex = 0; substringIndex < currentSubstring.Length; substringIndex++)
                        letters.Add(currentSubstring[substringIndex], substringIndex);
                }
            }

            longestSubstring = (longestSubstring.Length > currentSubstring.Length) ? longestSubstring : currentSubstring;

            return longestSubstring.Length;
        }
    }
}
