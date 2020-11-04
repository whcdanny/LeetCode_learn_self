public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        if (obstacleGrid[0][0] == 1)
		{
			return 0;
		}
        obstacleGrid[0][0] = 1;

        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;
        
        for(int i = 1; i<m; i++){
            if(obstacleGrid[i][0] == 0 && obstacleGrid[i - 1][0] == 1)
                obstacleGrid[i][0] = 1;
            else
                obstacleGrid[i][0] = 0;
        }
        for(int j = 1; j<n; j++){
            if(obstacleGrid[0][j] == 0 && obstacleGrid[0][j - 1] == 1)
                obstacleGrid[0][j] = 1;
            else
                obstacleGrid[0][j] = 0;
        }
        for(int i = 1; i<m; i++){
            for(int j = 1; j<n; j++){
                if (obstacleGrid[i][j] == 0)
                {
                    obstacleGrid[i][j] = obstacleGrid[i - 1][j] + obstacleGrid[i][j - 1];
                }
                else
                {
                    obstacleGrid[i][j] = 0;
                }                
            }
        }
        
        return obstacleGrid[m-1][n-1];
    }
}



class Solution:
    def uniquePathsWithObstacles(self, obstacleGrid: List[List[int]]) -> int:
        if not obstacleGrid or obstacleGrid[0][0]:
            return 0

        rows, cols = len(obstacleGrid), len(obstacleGrid[0])

        dp = [[None] * cols for _ in range(rows)]
        dp[0][0] = 1 if not obstacleGrid[0][0] else 0
        for col in range(1, cols):
            dp[0][col] = 0 if obstacleGrid[0][col] or not dp[0][col - 1] else 1
        for row in range(1, rows):
            dp[row][0] = 0 if obstacleGrid[row][0] or not dp[row - 1][0] else 1

        for row in range(1, rows):
            for col in range(1, cols):
                dp[row][col] = 0 if obstacleGrid[row][col] else dp[row - 1][col] + dp[row][col - 1]

        return dp[rows - 1][cols - 1]