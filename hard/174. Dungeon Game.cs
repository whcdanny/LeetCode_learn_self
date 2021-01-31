public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {
        int m = dungeon.Length - 1;
        int n = dungeon[0].Length - 1;
        if (m+1 == 0 || n+1 == 0)
        {
            return 0;
        }
        int[,] health = new int[m+1,n+1];            

        health[m,n] = Math.Max(1 - dungeon[m][n], 1);

        for (int i = m - 1; i >= 0; i--)
        {
            health[i,n] = Math.Max(health[i + 1,n] - dungeon[i][n], 1);
        }

        for (int i = n - 1; i >= 0; i--)
        {
            health[m,i] = Math.Max(health[m,i + 1] - dungeon[m][i], 1);
        }

        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                health[i,j] = Math.Min(Math.Max(health[i + 1,j] - dungeon[i][j], 1), Math.Max(health[i,j + 1] - dungeon[i][j], 1));
            }
        }

        return health[0,0];
    }
}

//Java
class Solution {
    public int calculateMinimumHP(int[][] dungeon) {
        if (dungeon.length == 0 || dungeon[0].length == 0) {
            return 0;
        }
        int[][] health = new int[dungeon.length][dungeon[0].length];

        int m = dungeon.length - 1;
        int n = dungeon[0].length - 1;

        health[m][n] = Math.max(1 - dungeon[m][n] , 1);

        for (int i = m - 1; i >= 0; i--) {
            health[i][n] = Math.max(health[i + 1][n] - dungeon[i][n], 1);
        }

        for (int i = n - 1; i >= 0; i--) {
            health[m][i] = Math.max(health[m][i+1] - dungeon[m][i], 1);
        }

        for (int i = m - 1; i >= 0; i--) {
            for (int j = n - 1; j >= 0; j--) {
                health[i][j] = Math.min(Math.max(health[i + 1][j] - dungeon[i][j], 1), Math.max(health[i][j + 1] - dungeon[i][j], 1));
            }
        }

        return health[0][0];
    }
}