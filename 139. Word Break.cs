public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
         if (wordDict == null || s == null)
        {
            return false;
        }

        int count = s.Length;
        bool[] dp = new bool[count + 1];

        dp[0] = true;

        for (var i = 1; i < dp.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                var word = s.Substring(j, i - j);
                if (wordDict.Contains(word) && dp[j])
                {
                    dp[i] = true;
                    break;
                }
            }
        }

        return dp[count];
    }
}