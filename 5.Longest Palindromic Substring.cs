/*Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

Example 1:

Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example 2:

Input: "cbbd"
Output: "bb"

""abbaabbaa"""abbaabba"*/

/*思路：比较头尾比较*/

public class Solution {
    public string LongestPalindrome(string s) {
        string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j <= s.Length - i; j++)
                {                    
                    if (j <= res.Length) continue;
                    if (IsPalindrome(s, i, j))
                    {
                        res = s.Substring(i, j);
                    }
                }
            }
            return res;
        }

        private bool IsPalindrome(string s, int offset, int length)
        {
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i + offset] != s[length - i - 1 + offset]) return false;
            }
            return true;
        }
}