public class Solution {
    public bool Exist(char[][] board, string word) {
        if (board.Length == 0) 
            return false;
        int rows = board.Length;
        int cols = board[0].Length;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (isExist(board, i, j, rows-1, cols-1, word, 0)) 
                    return true;
            }
        }

        return false;
    }
    public bool isExist(char[][] board, int i, int j, int rows, int cols, string word, int wordIndex)
    {
        if (wordIndex == word.Length) 
            return true;
        if (i < 0 || j < 0 || i > rows || j > cols || board[i][j] != word[wordIndex]) 
            return false;

        board[i][j] = ' ';
        bool check = isExist(board, i - 1, j, rows, cols, word, wordIndex + 1) ||
                    isExist(board, i, j - 1, rows, cols, word, wordIndex + 1) ||
                    isExist(board, i, j + 1, rows, cols, word, wordIndex + 1) ||
                    isExist(board, i + 1, j, rows, cols, word, wordIndex + 1);
        board[i][j] = word[wordIndex];
        return check;
    }
}


//Java
class Solution {
    public boolean exist(char[][] board, String word) {
        if (board.length == 0) 
            return false;
        int rows = board.length;
        int cols = board[0].length;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (isExist(board, i, j, rows-1, cols-1, word, 0)) 
                    return true;
            }
        }

        return false;
    }
     private boolean isExist(char[][] board, int i, int j, int rows, int cols, String word, int wordIndex){
         if (wordIndex == word.length()) 
            return true;
        if (i < 0 || j < 0 || i > rows || j > cols || board[i][j] != word.charAt(wordIndex))
            return false;

        board[i][j] = ' ';
        boolean check = isExist(board, i - 1, j, rows, cols, word, wordIndex + 1) ||
                    isExist(board, i, j - 1, rows, cols, word, wordIndex + 1) ||
                    isExist(board, i, j + 1, rows, cols, word, wordIndex + 1) ||
                    isExist(board, i + 1, j, rows, cols, word, wordIndex + 1);
        board[i][j] = word.charAt(wordIndex);
        return check;
     }
    
}