public class Solution {
    public int SingleNumber(int[] nums) {
        if (nums == null)
            return 0;
        if (nums.Length == 1)
            return nums[0];
        Array.Sort(nums);
        int res = nums[0];
        int time = 0;
        for(int i=1; i<nums.Length; i++)
        {
            if (res == nums[i])
                time += 1;
            if(res != nums[i])
            {
                if (time > 0)
                {
                    res = nums[i];
                    time = 0;
                }                        
                else
                    break;
            }
        }
        return res;
    }
}