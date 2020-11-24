public class Solution {
    public int NumTrees(int n) {
        if(n<=0){
            return 0;
        }
        int[] result = new int[n+1];
        result[0]=1;
        result[1]=1;
        for(int i=2;i<=n;i++){
            for(int j=1;j<=i;j++){
                result[i]+=result[j-1]*result[i-j];
            }
        }
        return result[n];
    }
}