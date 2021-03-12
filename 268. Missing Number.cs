public class Solution {
    public int MissingNumber(int[] nums) {
        int size = nums.Length;
        
        int sum1=0;
        int sum2=0;
        if(size==1 && nums[0]==0){
            return 1;
        }
        if(size==1 && nums[0]==1){
            return 0;
        }
        
        for(int i=0;i<size;i++){
            sum1+=nums[i];
        }
        for(int i=0; i<=size; i++){
            sum2+=i;
        }
        int res=sum2-sum1;
        return res;
    }
}

//C++
class Solution {
public:
    int missingNumber(vector<int>& nums) {
        int size = nums.size();
        //int n = nums[size-1];
        int sum1=0;
        int sum2=0;
        if(size==1 && nums[0]==0){
            return 1;
        }
        if(size==1 && nums[0]==1){
            return 0;
        }
        
        for(int i=0;i<size;i++){
            sum1+=nums[i];
        }
        for(int i=0; i<=size; i++){
            sum2+=i;
        }
        int res=sum2-sum1;
        return res;
    }
};

//Java
class Solution {
    public int missingNumber(int[] nums) {
        int size = nums.length;
        
        int sum1=0;
        int sum2=0;
        if(size==1 && nums[0]==0){
            return 1;
        }
        if(size==1 && nums[0]==1){
            return 0;
        }
        
        for(int i=0;i<size;i++){
            sum1+=nums[i];
        }
        for(int i=0; i<=size; i++){
            sum2+=i;
        }
        int res=sum2-sum1;
        return res;
    }
}