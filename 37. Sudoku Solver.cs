/*Write a program to solve a Sudoku puzzle by filling the empty cells.

A sudoku solution must satisfy all of the following rules:

Each of the digits 1-9 must occur exactly once in each row.
Each of the digits 1-9 must occur exactly once in each column.
Each of the the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.
Empty cells are indicated by the character '.'.*/

/*思路：先把已经有的标记为true，然后检查横竖3x3，然后放入一个都没有的数字。*/

public class Solution {
    
    bool[,] _rows = new bool[9, 9], _cols = new bool[9, 9], _box = new bool[9, 9];
    bool _finished = false;
    
    public void SolveSudoku(char[][] board) {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (board[row][col] != '.')
                {
                    _rows[row, board[row][col] - '1'] = true;
                    _cols[col, board[row][col] - '1'] = true;
                    _box[row / 3 * 3 + col / 3, board[row][col] - '1'] = true;
                }
            }
        }
        SolveSudoku(board, 0, 0);    
    }
    private void SolveSudoku(char[][] board, int row, int col)
    {            
        if (row == 9)
        {
            _finished = true;
            return;
        }
        if (board[row][col] != '.')
        {
            if (col == 8)
            {
                SolveSudoku(board, row + 1, 0);
            }
            else
            {
                SolveSudoku(board, row, col + 1);
            }
        }
        else
        {
            int box = row / 3 * 3 + col / 3;
            for (int i = 0; i < 9; i++)
            {                                       
                if (!_rows[row, i] && !_cols[col, i] && !_box[box, i])
                {
                    board[row][col] = (char)(i + '1');
                    _rows[row, i] = true;
                    _cols[col, i] = true;
                    _box[box, i] = true;                       
                    if (col == 8)
                    {
                        SolveSudoku(board, row + 1, 0);
                    }
                    else
                    {
                        SolveSudoku(board, row, col + 1);
                    }                       
                    if (!_finished)
                    {
                        board[row][col] = '.';
                        _rows[row, i] = false;
                        _cols[col, i] = false;
                        _box[box, i] = false;
                    }
                }
            }
        }
    }   
}