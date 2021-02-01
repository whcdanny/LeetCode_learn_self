public class Solution {
    public int NumIslands(char[][] grid) {
        int res = 0;
        for(int i=0; i<grid.Length; i++)
        {
            for(int j=0; j<grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    res++;
                    checkedIsland(grid, i, j);
                }
            }
        }
        return res;
    }
    private void checkedIsland(char[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == '0')
            return;
        grid[i][j] = '0';
        checkedIsland(grid,i,j-1);
        checkedIsland(grid, i, j + 1);
        checkedIsland(grid, i - 1, j);
        checkedIsland(grid, i + 1, j);
    }
}

//Java
class Solution {
    public int numIslands(char[][] grid) {
        int count = 0;       
        for(int i = 0; i < grid.length; i++){
            for(int j = 0; j < grid[i].length; j++){
                if(grid[i][j] == '1') {
                    // island
                    count++;
                    checkIslands(grid, i, j);
                }
            }
        }
        return count;
    }
    public void checkIslands(char[][] grid, int i, int j){        
        if(j < 0 || j >= grid[0].length || i < 0 || i >= grid.length || grid[i][j] == '0'){
            return;
        }
        grid[i][j] = '0';        
        checkIslands(grid, i, j-1);
        checkIslands(grid, i, j+1);        
        checkIslands(grid, i-1, j);
        checkIslands(grid, i+1, j);
    }
}