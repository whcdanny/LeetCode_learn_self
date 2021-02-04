public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        if (nums == null || nums.Length == 0)
                return 0;
        int left = 0;
        int right = -1;
        int sum = 0;
        int res = nums.Length + 1;
        while (left < nums.Length)
        {
            if (sum < target && right + 1 < nums.Length)
            {
                right++;
                sum += nums[right];
            }
            else
            {
                sum -= nums[left];
                left++;
            }
            if (sum >= target)
            {
                res = Math.Min(res, right - left + 1);
            }
        }
        if (res == nums.Length + 1)
            return 0;
        return res;
    }
}

//Java
class Solution {
    public int minSubArrayLen(int target, int[] nums) {
        if (nums ==null || nums.length==0) 
            return 0;    
    
        int l = 0, r=-1;
        int sum =0;
    
        int result =nums.length+1;
    
        while(l< nums.length)
        {
            if(sum <target && r+1<nums.length)
            {
                r++;
                sum +=nums[r];
            }
            else
            {
                sum -=nums[l];
                l++;
            }
        
            if(sum >= target)
            {
                result = Math.min(result, r-l+1);
    
            }
        }
    
    
        if (result == nums.length+1)  
            return 0;
    
        return result; 
    }
}