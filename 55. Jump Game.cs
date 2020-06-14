/*Given an array of non-negative integers, you are initially positioned at the first index of the array.

Each element in the array represents your maximum jump length at that position.

Determine if you are able to reach the last index.

 

Example 1:

Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:

Input: nums = [3,2,1,0,4]
Output: false
Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.*/

/*思路：*/

public class Solution {
    public bool CanJump(int[] nums) {
        int res =  Jump(nums);
        if(res < 0)
            return false;
        else
            return true;
    }
    public int Jump(int[] nums) {
        if (nums.Length <= 1)
        {
            return 0;
        }

        var maxPos = 0;
        var minSteps = new int[nums.Length];
        for (var i = 0; i <= nums.Length - 1; i++)
        {
            minSteps[i] = int.MaxValue;
        }
        minSteps[0] = 0;

        for (var i = 0; i <= nums.Length - 1; i++)
        {
            var j = maxPos + 1;
            while ((j <= nums.Length - 1) && (j <= nums[i] + i))
            {
                minSteps[j] = minSteps[i] + 1;
                j++;
            }

            maxPos = Math.Max(nums[i] + i, maxPos);

            if (maxPos >= nums.Length - 1)
            {
                return minSteps[nums.Length - 1];
            }
        }

        return -1;
    }
}