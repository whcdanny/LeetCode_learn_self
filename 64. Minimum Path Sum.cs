public class Solution {
    public int MinPathSum(int[][] grid) {
        for (int i = 0; i < grid.Length; i++)
		{
			for (int j = 0; j < grid[i].Length; j++)
			{
				if (i == 0 && j == 0)
				{
					grid[i][j] = grid[i][j];
				}
				else if (j == 0)
				{
					grid[i][j] = grid[i - 1][j] + grid[i][j];
				}
				else if (i == 0)
				{
					grid[i][j] = grid[i][j - 1] + grid[i][j];
				}
				else
				{
					grid[i][j] = Math.Min(grid[i][j - 1], grid[i - 1][j]) + grid[i][j];
				}
			}
		}
		return grid.LastOrDefault().LastOrDefault();
    }
}


class Solution:
    def minPathSum(self, grid: List[List[int]]) -> int:
        for i in range(len(grid)):
            for j in range(len(grid[0])):
                if i == j == 0: continue
                elif i == 0:  grid[i][j] = grid[i][j - 1] + grid[i][j]
                elif j == 0:  grid[i][j] = grid[i - 1][j] + grid[i][j]
                else: grid[i][j] = min(grid[i - 1][j], grid[i][j - 1]) + grid[i][j]
        return grid[-1][-1]