public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length < 2) return nums.Length;
        int i = 0;

        for (var j = 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {
                if (i > 0 && nums[i] == nums[i - 1]) 
                    continue; 
            }

            i++; 
            nums[i] = nums[j]; 
        }

        return i + 1;
    }
}