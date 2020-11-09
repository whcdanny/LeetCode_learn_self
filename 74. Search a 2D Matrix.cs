public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {        
        if(matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return false;
        int n = matrix.Length;
        int m = matrix[0].Length;
        bool res = false;
        
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(matrix[i][j] == target){
                    res = true;
                    break;
                }
            }
        }
        
        return res;
    }
}

public bool SearchMatrix(int[,] matrix, int target)
        {
            var rowCount = matrix.GetLength(0);
            var colCount = matrix.GetLength(1);

            var row = rowCount - 1;
            var col = 0;

            while (row >= 0 && col < colCount)
            {
                if (matrix[row, col] == target)
                    return true;

                if (target < matrix[row, col])
                    row--;
                else
                    col++;
            }

            return false;
        }