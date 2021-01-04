public class Solution {
    public int NumDistinct(string s, string t) {
        int m = s.Length;
        int n = t.Length;

        int[,] dp = new int[m + 1, n + 1];

        char[] sChar = s.ToCharArray();
        char[] tChar = t.ToCharArray();
        
        for(int i=0; i <= m; i++)
        {
            dp[i,0] = 1;
        }
        for (int j = 1; j <= n; j++)
        {
            dp[0, j] = 0;
        }

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (sChar[i - 1].Equals( tChar[j - 1]))
                {
                    dp[i, j] = dp[i - 1, j] + dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = dp[i - 1,j];
                }
            }
        }

        return dp[m,n];
    }
}

//Java
class Solution {
    public int numDistinct(String s, String t) {
        int m = s.length();
        int n = t.length();
        int[][] dp = new int[m + 1][n + 1];

        char[] schar = s.toCharArray();
        char[] tchar = t.toCharArray();

        for (int i = 0; i <= m; i++) {
            dp[i][0] = 1;
        }

        for (int j = 1; j <= n; j++) {
            dp[0][j] = 0;
        }

        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
            if (schar[i - 1] == tchar[j - 1]) {
                dp[i][j] = dp[i - 1][j] + dp[i - 1][j - 1];
            } else {
                dp[i][j] = dp[i - 1][j];
            }
            }
        }
         return dp[m][n];
    }
}