public class Solution {
    public int MaximalSquare(char[][] matrix) {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return 0;
        int row = matrix.Length;
        int col = matrix[0].Length;

        int maxLength = 0;

        int[,] dp = new int[row + 1, col + 1];
        for(int i=1; i<=row; i++)
        {
            for(int j=1; j<=col; j++)
            {
                if (matrix[i - 1][ j - 1] == '1')
                {
                    dp[i, j] = Math.Min(Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1])+1;
                    maxLength = Math.Max(maxLength, dp[i, j]);
                }
            }
        }
        return maxLength * maxLength;
    }
}

//Java
class Solution {
    public int maximalSquare(char[][] matrix) {                      
        if (matrix == null || matrix.length == 0 || matrix[0].length == 0)
            return 0;        
        
        int row = matrix.length;
        int col = matrix[0].length;
        
        int maxLength = 0;
        
        int[][] DP = new int[row + 1][col + 1];
        for (int i = 1; i <= row; i++) {
            for (int j = 1; j <= col; j++) {
                if (matrix[i - 1][j - 1] == '1') {
                    DP[i][j] = Math.min(Math.min(DP[i - 1][j], DP[i][j  -1]),DP[i - 1][j - 1]) + 1;
                    maxLength = Math.max(maxLength, DP[i][j]);
                }
            }
        }
        
        return maxLength * maxLength;
    }
}