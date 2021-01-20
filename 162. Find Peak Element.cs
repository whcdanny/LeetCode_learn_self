public class Solution {
    public int FindPeakElement(int[] nums) {
        if (nums == null || nums.Length==0)
            return -1;
        if (nums.Length == 1)
            return 0;
        if (nums.Length == 2)
            return nums[0] > nums[1] ? 0 : 1;
        int res=0;
        for(int i=1; i < nums.Length - 1; i++)
        {
            if (nums[i - 1] < nums[i] && nums[i] > nums[i + 1])
                res = i;
            if (i + 1 == nums.Length - 1 && nums[i] < nums[i + 1])
                res = i+1;
        }
        return res;
    }
}

//Java
class Solution {
    public int findPeakElement(int[] nums) {
        if (nums == null) return -1;
        if (nums.length == 1) return 0;
        
        int left = 0, right = nums.length - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] < nums[mid+1]) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }

        return left;
    }
}