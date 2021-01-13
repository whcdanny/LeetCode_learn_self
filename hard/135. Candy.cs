public class Solution {
    public int Candy(int[] ratings) {
        int size = ratings.Length;
        int res = 0;
        if (size == 0)
            return -1;
        if (size == 1)
            return 1;
        int[] candy = new int[size];
        candy[0] = 1;
        for (int i = 1; i < size; i++)
        {
            if (ratings[i] > ratings[i - 1])
                candy[i] = candy[i - 1] + 1;
            else
                candy[i] = 1;
        }
        for(int i=size-2; i>=0; i--)
        {
            if (ratings[i] > ratings[i + 1] && candy[i] <= candy[i + 1])
                candy[i] = candy[i + 1] + 1;
        }
        foreach (int val in candy)
            res += val;
        return res;
    }
}

//Java
public class Solution {
    public int candy(int[] ratings) {
        int size = ratings.length;
        if(size==0)
            return -1;
        if(size==1)
            return 1;
        
        int[] candy = new int[size];
        candy[0]=1;
        
        for(int i=1;i<size;i++){
            if(ratings[i-1]<ratings[i])
                candy[i]=candy[i-1]+1;
            else if(ratings[i-1]==ratings[i])
                candy[i]=1;
            else
                candy[i]=1;
        }
        
        for(int i=size-2;i>=0;i--){
            if(ratings[i]>ratings[i+1]&&candy[i]<=candy[i+1]){
                candy[i]=candy[i+1]+1;
            }
        }
        int result=0;
        for(int i=0;i<size;i++){
            result +=candy[i];
        }
        return result;
    }
}