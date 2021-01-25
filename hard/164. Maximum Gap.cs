public class Solution {
    public int MaximumGap(int[] nums) {
        int res = 0;
        if (nums.Length == 0 || nums.Length == 1)
            return res;
        Array.Sort(nums);
        for(int i = 1; i < nums.Length; i++)
        {
            int val = nums[i] - nums[i - 1];
            if (val > res)
                res = val;
        }
        return res;
    }
}

//Java
class Solution {
    public int maximumGap(int[] nums) {
        int res = 0;
        if (nums.length == 0 || nums.length == 1)
                return res;
        Arrays.sort(nums);
        for(int i = 1; i < nums.length; i++)
        {
            int val = nums[i] - nums[i - 1];
            if (val > res)
                res = val;
        }
        return res;
    }
}