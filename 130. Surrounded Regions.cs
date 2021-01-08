public class Solution {
    public void Solve(char[][] board) {
        

        if (board.Length == 0 || board[0].Length == 0 || board==null)
            return;
        int m = board.Length;
        int n = board[0].Length;
        bool[,] check = new bool[m,n];

        for(int i = 1; i < m-1; i++)
        {
            checkO(board, check, i, 0);
            checkO(board, check, i, n - 1);
        }
        for(int i=0; i < n; i++)
        {
            checkO(board, check, 0, i);
            checkO(board, check, m-1, i);
        }

        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                if (board[i][j] == 'O' && !check[i,j])
                {
                    board[i][j] = 'X';
                }
            }
        }
    }
    private void checkO(char[][] board, bool[,] check, int i, int j)
    {
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] == 'X' || check[i,j])
        {
            return;
        }
        check[i,j] = true;
        checkO(board, check, i + 1, j);
        checkO(board, check, i - 1, j);
        checkO(board, check, i, j + 1);
        checkO(board, check, i, j - 1);
        }
}


//Java
class Solution {
    public void solve(char[][] board) {
        if (board == null || board.length == 0 || board[0].length == 0) {
            return;
        }
        
        boolean[][] check = new boolean[board.length][board[0].length];
        
        for (int i = 0; i < board[0].length; i++) {
            helper(board, check, 0, i);
            helper(board, check, board.length - 1, i);
        }
        for (int i = 1; i < board.length - 1; i++) {
            helper(board, check, i, 0);
            helper(board, check, i, board[0].length - 1);
        }
        
        for (int i = 0; i < board.length; i++) {
            for (int j = 0; j < board[0].length; j++) {
                if (board[i][j] == 'O' && !check[i][j]) {
                    board[i][j] = 'X';
                }
            }
        }
    }
    private void helper(char[][] board, boolean[][] check, int i, int j) {
        if (i < 0 || i >= board.length || j < 0 || j >= board[0].length || board[i][j] == 'X' || check[i][j]) {
            return;
        }
        check[i][j] = true;
        helper(board, check, i + 1, j);
        helper(board, check, i - 1, j);
        helper(board, check, i, j + 1);
        helper(board, check, i, j - 1);
    }
}