public class Solution {
    public int UniquePaths(int m, int n) {
        int[,] list = new int[m, n];
        for(int i = 0; i<m; i++){
            list[i,0] = 1;
        }
        for(int j = 0; j<n; j++){
            list[0,j] = 1;
        }
        for(int i = 1; i<m; i++){
            for(int j = 1; j<n; j++){
                list[i,j] = list[i-1,j] + list[i,j-1];
            }
        }
        
        return list[m-1,n-1];
    }
}


class Solution:
    def uniquePaths(self, m: int, n: int) -> int:
        t = [0] * n
        for i in range(n):
            t[i] = [0]*m

        t[0][0] = 1
        
        for i in range(1, m):
            t[0][i] = 1
            
        for j in range(1, n):
            t[j][0] = 1
            
        for i in range(1, m):
            for j in range(1, n):
                t[j][i] = t[j-1][i] + t[j][i-1]
                
                
        return t[n-1][m-1]