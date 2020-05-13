/*给定一个二维矩阵，计算其子矩形范围内元素的总和，该子矩阵的左上角为 (row1, col1) ，右下角为 (row2, col2)。
  上图子矩阵左上角 (row1, col1) = (2, 1) ，右下角(row2, col2) = (4, 3)，该子矩形内元素的总和为 8。
  
  示例:
  
  给定 matrix = [
 [3, 0, 1, 4, 2],
 [5, 6, 3, 2, 1],
 [1, 2, 0, 1, 5],
 [4, 1, 0, 1, 7],
 [1, 0, 3, 0, 5]
 ]
  
  sumRegion(2, 1, 4, 3) -> 8
  sumRegion(1, 1, 2, 2) -> 11
  sumRegion(1, 2, 2, 4) -> 12
  
  思路： 用需要的总面积_-上面 - 左侧-左侧的上面
  */

public class NumMatrix
{
    private int[,] _dp;
    public NumMatrix(int[][] matrix)
    {
        if (matrix.Length < 1)
        {
            _dp = new int[0, 0];
            return;
        }
        _dp = new int[matrix.Length, matrix[0].Length];
        for (int i = 0; i < matrix.Length; i++)
        {
            var sum = 0;
            for (int j = 0; j < matrix[i].Length; j++)
            {
                var a = i > 0 ? _dp[i - 1, j] : 0;
                sum += matrix[i][j];
                _dp[i, j] = a + sum;
            }
        }
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        var up = row1 > 0 ? _dp[row1 - 1, col2] : 0;
        var left = col1 > 0 ? _dp[row2, col1 - 1] : 0;
        var leftUp = row1 > 0 && col1 > 0 ? _dp[row1 - 1, col1 - 1] : 0;
        return _dp[row2, col2] - up - left + leftUp;
    }
}