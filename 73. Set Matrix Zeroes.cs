public class Solution {
    public void SetZeroes(int[][] matrix) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        
        List<int> h = new List<int>();
        List<int> w = new List<int>();
        
        for(int i = 0; i<n; i++){
            for(int j =0; j<m; j++){
                if(matrix[i][j]==0){
                    h.Add(i);
                    w.Add(j);
                }
            }
        }
        foreach(int v in h){
            for(int i = 0; i < m; i++){
                if(matrix[v][i]!=0){
                    matrix[v][i]=0;
                }
            }
        }
        foreach(int v in w){
            for(int i = 0; i < n; i++){
                if(matrix[i][v]!=0){
                    matrix[i][v]=0;
                }
            }
        }
    }
}