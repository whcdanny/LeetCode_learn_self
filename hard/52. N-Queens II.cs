/*The n-queens puzzle is the problem of placing n queens on an n×n chessboard such that no two queens attack each other.



Given an integer n, return the number of distinct solutions to the n-queens puzzle.

Example:

Input: 4
Output: 2
Explanation: There are two distinct solutions to the 4-queens puzzle as shown below.
[
 [".Q..",  // Solution 1
  "...Q",
  "Q...",
  "..Q."],

 ["..Q.",  // Solution 2
  "Q...",
  "...Q",
  ".Q.."]
]*/

/*思路：*/

public class Solution {
    public int TotalNQueens(int n) {
        var result = new List<IList<string>>();
        SolveNQueens(n, new List<string>(), result);
        
        return result.Count;
    }
    
    private void SolveNQueens(int n, IList<string> rows, IList<IList<string>> result) {
        if (rows.Count == n) {
            result.Add(new List<string>(rows));
            return;
        }
        
        for (var i = 0; i < n; i++) {
            if (!IsValid(i, rows)) {
                continue;
            }
            
            var c = Enumerable.Repeat('.', n).ToArray();
            c[i] = 'Q';
            
            rows.Add(new string(c));
            SolveNQueens(n, rows, result);
            rows.RemoveAt(rows.Count - 1);
        }
    }
    
    private bool IsValid(int col, IList<string> rows) {
        var n = rows.Count;
        for (var i = 0; i < n; i++) {
            var j = rows[i].IndexOf('Q');
            if (j == col) {
                return false;
            }
            
            if (Math.Abs(col - j) == Math.Abs(n - i)) {
                return false;
            }
        }
        
        return true;        
    }
}