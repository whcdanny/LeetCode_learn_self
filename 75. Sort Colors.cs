public class Solution {
    public void SortColors(int[] nums) {
        if (nums == null || nums.Length == 0)
        {
            return;
        }

        int low = 0, mid = nums.Length - 1, high = nums.Length - 1;

        while (low <= mid)
        {
            if (nums[mid] == 0)
            {
                nums[mid] = nums[low];
                nums[low] = 0;
                low++;
            }
            else if (nums[mid] == 1)
            {
                mid--;
            }
            else if (nums[mid] == 2)
            {
                nums[mid] = nums[high];
                nums[high] = 2;
                high--;
                mid = Math.Min(mid, high);
            }
        }
    }
}