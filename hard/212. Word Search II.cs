public class Solution {
    public IList<string> FindWords(char[][] board, string[] words)
    {
        IList<string> wordsFound = new List<string>();

        foreach (string word in words)
        {
            if (findWord(board, word))
            {
                wordsFound.Add(word);
            }
        }

        return wordsFound;
    }
    private static bool findWord(char[][] board, string word)
    {
        if (board == null || board.Length == 0 || board[0].Length == 0 || word == null || word.Length == 0)
        {
            return false;
        }

        int rows = board.Length;
        int cols = board[0].Length;
        
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                char visit = board[row][col];
                bool startSearch = visit == word[0];
                
                if (!startSearch)
                    continue;
                
                var memo = new bool[rows, cols];
                bool foundOne = searchWord(board, word, row, col, 0, memo);
                
                if (foundOne)
                {
                    return true;
                }
            }
        }

        return false;
    }
    private static bool searchWord(char[][] board, string word, int startRow, int startCol, int index, bool[,] memo)
    {            
        if (!isInBoundary(board, startRow, startCol) || memo[startRow, startCol])
            return false;

        char visit = board[startRow][startCol];
        int length = word.Length;

        bool isEqual = index < length && visit == word[index];
        bool isLastChar = index == (length - 1);
        
        if (!isEqual)
            return false;

        memo[startRow, startCol] = true;
        
        if (isLastChar)
            return true;

        int nextIndex = index + 1;
        bool result =
                       searchWord(board, word, startRow, startCol - 1, nextIndex, memo) ||
                       searchWord(board, word, startRow, startCol + 1, nextIndex, memo) ||
                       searchWord(board, word, startRow - 1, startCol, nextIndex, memo) ||
                       searchWord(board, word, startRow + 1, startCol, nextIndex, memo);

        if (!result)
            memo[startRow, startCol] = false;

        return result;
    }

    private static bool isInBoundary(char[][] board, int startRow, int startCol)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        return startRow >= 0 && startRow < rows && startCol >= 0 && startCol < cols;
    }
}

//Java
class Solution {
    class TrieNode {
        TrieNode[] children = new TrieNode[26];
        String word;
    }

    
    public TrieNode buildTrie(String[] words) {
        TrieNode root = new TrieNode();
        for (String w : words) {
            TrieNode current = root;
            for (char c : w.toCharArray()) {
                int i = c - 'a'; 
                if (current.children[i] == null) 
					current.children[i] = new TrieNode();
                current = current.children[i];
            }
            current.word = w; 
        }
		
        return root;
    }
    public List<String> findWords(char[][] board, String[] words) {
        List<String> result = new ArrayList<>();
        
        TrieNode root = buildTrie(words);

        // call the dfs
        for (int i = 0; i < board.length; i++) {
            for (int j = 0; j < board[0].length; j++) {
                dfs(board, i, j, root, result);
            }
        }

        return result;
    }
    public void dfs(char[][] board, int i, int j, TrieNode root, List<String> result) {
        char c = board[i][j]; 
        if (c == '*' || root.children[c - 'a'] == null)
            return;
        root = root.children[c - 'a'];
        if (root.word != null) {               
            result.add(root.word);
            root.word = null;     
        }

        board[i][j] = '*'; 
        if (i > 0) dfs(board, i - 1, j, root, result); 
        if (j > 0) dfs(board, i, j - 1, root, result); 
        if (i < board.length - 1) dfs(board, i + 1, j, root, result); 
        if (j < board[0].length - 1) dfs(board, i, j + 1, root, result); 
        board[i][j] = c; 
    }
}