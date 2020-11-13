public class Solution {
    public int NumDecodings(string s) {
        if (s == null || s.Length == 0)
            return 0;

        int[] dp = new int[s.Length + 1];
        dp[0] = 1;
        if (s[0] != '0')
            dp[1] = 1;

        for (int i = 2; i <= s.Length; i++)
        {
            if (s[i - 1] != '0')
                dp[i] += dp[i - 1];

            int d = (s[i - 2] - '0') * 10 + (s[i - 1] - '0');
            if (d >= 10 && d <= 26)
                dp[i] += dp[i - 2];
        }
        return dp[s.Length];
    }
    
}