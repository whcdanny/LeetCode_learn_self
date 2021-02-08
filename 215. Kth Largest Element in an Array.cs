public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        Array.Sort(nums);
        return nums[nums.Length - k];
    }
}

//Java
class Solution {
    public int findKthLargest(int[] nums, int k) {
        Arrays.sort(nums);
        return nums[nums.length - k];
    }
}