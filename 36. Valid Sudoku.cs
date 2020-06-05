/*Determine if a 9x9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the 9 3x3 sub-boxes of the grid must contain the digits 1-9 without repetition.

A partially filled sudoku which is valid.

The Sudoku board could be partially filled, where empty cells are filled with the character '.'.

Example 1:

Input:
[
  ["5","3",".",".","7",".",".",".","."],
  ["6",".",".","1","9","5",".",".","."],
  [".","9","8",".",".",".",".","6","."],
  ["8",".",".",".","6",".",".",".","3"],
  ["4",".",".","8",".","3",".",".","1"],
  ["7",".",".",".","2",".",".",".","6"],
  [".","6",".",".",".",".","2","8","."],
  [".",".",".","4","1","9",".",".","5"],
  [".",".",".",".","8",".",".","7","9"]
]
Output: true
Example 2:

Input:
[
  ["8","3",".",".","7",".",".",".","."],
  ["6",".",".","1","9","5",".",".","."],
  [".","9","8",".",".",".",".","6","."],
  ["8",".",".",".","6",".",".",".","3"],
  ["4",".",".","8",".","3",".",".","1"],
  ["7",".",".",".","2",".",".",".","6"],
  [".","6",".",".",".",".","2","8","."],
  [".",".",".","4","1","9",".",".","5"],
  [".",".",".",".","8",".",".","7","9"]
]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being 
    modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.*/
	
/*思路：横 竖 3x3全部检查一下*/

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<char, bool> found = new Dictionary<char, bool>();
            char[] digits = "123456789".ToCharArray();
            foreach (var c in digits)
            {
                found.Add(c, false);
            }
            // row
            for (var i = 0; i < 9; i++)
            {
                foreach (var c in digits)
                {
                    found[c] = false;
                }
                for (int j = 0; j < 9; j++)
                {
                    var c = board[i][j];
                    if (c == '.')
                        continue;
                    if (found[c])
                    {
                        return false;
                    }
                    found[c] = true;
                }
            }
            // col
            for (var i = 0; i < 9; i++)
            {
                foreach (var c in digits)
                {
                    found[c] = false;
                }
                for (int j = 0; j < 9; j++)
                {
                    var c = board[j][i];
                    if (c == '.')
                        continue;
                    if (found[c])
                    {
                        return false;
                    }
                    found[c] = true;
                }
            }
            // 3x3 sub-boxes
            for (var i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    foreach (var c in digits)
                    {
                        found[c] = false;
                    }
                    for (int m = 0; m < 3; m++)
                    {
                        for (int n = 0; n < 3; n++)
                        {
                            var c = board[i * 3 + m][j * 3 + n];
                            if (c == '.')
                                continue;
                            if (found[c])
                            {
                                return false;
                            }
                            found[c] = true;
                        }
                    }
                }
            }

            return true;
    }
}