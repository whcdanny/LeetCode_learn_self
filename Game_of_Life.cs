/*
Game of Life
0 表示死
1 表示活
规则：
1. 如果本身是活（1）的：如果周围少于2个活（1）的； 你死（0）
2. 如果本身是活（1）的：如果周围多于3个活（1）的； 你死（0）
3. 如果本身是活（1）的：如果周围有2个或3活（1）的； 你活（1）
4. 如果本身是死（0）的：如果周围少于2个活（1）的； 你活（1）
*/

public class Solution {
    public void GameOfLife(int[][] board) {
        int row = board.Length;
        int colum = board[0].Length;   
        var newBoard = new int[row][];
            for (int i = 0; i < row; i++)
            {
                newBoard[i] = new int[colum];
                for (int j = 0; j < colum; j++)
                {
                    newBoard[i][j] = checkNectState(i, j, board);
                }
            }
        for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    board[i][j] = newBoard[i][j];
                }
            }
    }
    private int checkNectState(int _i, int _j, int[][] A)
        {                       
            int res = 0;//Dead            
            int state = A[_i][_j];            
            int liveSum = 0;
            int row = A.Length;
            int colum = A[0].Length;
            //1
            if (_i - 1 >= 0 && _j - 1 >= 0)
            {               
                if (checkedState(A[_i - 1][_j - 1]))
                    liveSum++;                                               
            }
            //2
            if (_i - 1 >= 0)
            {
                if (checkedState(A[_i - 1][_j]))
                    liveSum++;
            }
            //3
            if ( _j-1 >= 0)
            {
                if (checkedState(A[_i][_j-1]))
                    liveSum++;
            }
            //4
            if (_i + 1 >= 0 && _j + 1 >= 0 && _i + 1 < row && _j + 1 < colum)
            {
                if (checkedState(A[_i + 1][_j + 1]))
                    liveSum++;                              
            }  
            //5
            if(_i + 1 >= 0 && _i + 1 < row)
            {
                if (checkedState(A[_i + 1][_j]))
                    liveSum++;
            }
            //6
            if (_j + 1 >= 0 && _j + 1 < colum)
            {
                if (checkedState(A[_i][_j + 1]))
                    liveSum++;
            }
            //7
            if (_i - 1 >= 0 && _j + 1 >= 0 && _j + 1 < colum)
            {
                if (checkedState(A[_i - 1][_j + 1]))
                    liveSum++;                                
            }
            //8
            if (_i + 1 >= 0 && _j - 1 >= 0 && _i + 1 < row)
            {
                if (checkedState(A[_i + 1][_j - 1]))
                    liveSum++;                                
            }
           
            if (state == 1)
            {
                if (liveSum == 2 || liveSum == 3)
                    res = 1;
                else
                    res = 0;
            }
            else
            {
                if (liveSum == 3)
                    res = 1;
            }
            return res;
        }

        private bool checkedState(int state)
        {
            if (state == 0)
                return false;//dead
            else
                return true;//live
        }
}