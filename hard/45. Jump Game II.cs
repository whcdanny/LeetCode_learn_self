/*Given an array of non-negative integers, you are initially positioned at the first index of the array.

Each element in the array represents your maximum jump length at that position.

Your goal is to reach the last index in the minimum number of jumps.

Example:

Input: [2,3,1,1,4]
Output: 2
Explanation: The minimum number of jumps to reach the last index is 2.
    Jump 1 step from index 0 to 1, then 3 steps to the last index.*/
/*思路：算出每一步的最小步， 然后再计算之前的*/

public class Solution {
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