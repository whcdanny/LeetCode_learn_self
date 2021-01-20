public class Solution {
    public int FindMin(int[] nums) {
        int i = 0;
        int j = nums.Length-1;
        while (i + 1 < j)
        {
            if (nums[i] < nums[j])
                return nums[i];
            int mid = i + (j - i) / 2;
            if (nums[mid] > nums[j])
                i = mid;
            else if (nums[mid] < nums[j])
                j = mid;
            else
                j--;
        }
        return Math.Min(nums[i], nums[j]);
    }
}

//Java
class Solution {
    public int findMin(int[] nums) {
        int lo = 0;
        int hi = nums.length - 1;
        
        while(lo + 1 < hi) {
            if(nums[lo] < nums[hi]) return nums[lo];
            int mid = lo + (hi - lo) / 2;
            if(nums[mid] > nums[hi]) {
                lo = mid;
            } else if(nums[mid] < nums[hi]) {
                hi = mid;
            } else {
                hi --;
            }
        }
        
        return Math.min(nums[lo], nums[hi]);
    }
    
}