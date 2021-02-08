public class Solution {
    public int Rob(int[] nums) {
        if (nums == null || nums.Length == 0)            
            return 0;            
        if (nums.Length == 1)            
            return nums[0];            
        if (nums.Length == 2)            
            return Math.Max(nums[0], nums[1]);            
        int[] dp = new int[nums.Length - 1];
            
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);
        for (int i = 2; i < nums.Length - 1; i++)
        {
            dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
        }
        int prevMax = dp[nums.Length - 2];
            
        dp = new int[nums.Length - 1];
        dp[0] = nums[1];
        dp[1] = Math.Max(nums[1], nums[2]);
        for (int i = 3; i < nums.Length; i++)
        {
            dp[i - 1] = Math.Max(dp[i - 3] + nums[i], dp[i - 2]);
        }
        return Math.Max(prevMax, dp[nums.Length - 2]);
    }
}

//Java
class Solution {
    public int rob(int[] nums) {
        if (nums == null || nums.length == 0) {
            return 0;
        }
        if (nums.length == 1) {
            return nums[0];
        }
        if (nums.length == 2) {
            return Math.max(nums[0], nums[1]);
        }
        int[] dp = new int[nums.length - 1];
            
        dp[0] = nums[0];
        dp[1] = Math.max(nums[0], nums[1]);
        for (int i = 2; i < nums.length - 1; i++) {
            dp[i] = Math.max(dp[i - 2] + nums[i], dp[i - 1]);
        }
        int prevMax = dp[nums.length - 2];
        
        dp = new int[nums.length - 1];
        dp[0] = nums[1];
        dp[1] = Math.max(nums[1], nums[2]);
        for (int i = 3; i < nums.length; i++) {
            dp[i - 1] = Math.max(dp[i - 3] + nums[i], dp[i - 2]);
        }
        return Math.max(prevMax, dp[nums.length - 2]);
    }
}