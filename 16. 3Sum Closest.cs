/*Given an array nums of n integers and an integer target, find three integers in nums such that the sum is closest to target. Return the sum of the three integers. You may assume that each input would have exactly one solution.

 

Example 1:

Input: nums = [-1,2,1,-4], target = 1
Output: 2
Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).*/

/*思路：先把所有sum算出 然后找出差值最小的*/

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);

        var results = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var a = nums[i];
            var l = i + 1;
            var r = nums.Length - 1;

            while (l < r)
            {
                var b = nums[l];
                var c = nums[r];

                var sum = a + b + c;

                if (sum > target)
                {
                    r--;
                } else
                {
                    l++;
                }
                
                results.Add(sum);
            }
        }

        results.Sort();

        if (results.Count > 0)
        {
            var minDiff = int.MaxValue;
            var index = results.Count - 1;
            
            for (var i = 0; i < results.Count; i++)
            {
                var diff = Math.Abs(target - results[i]);
                
                if (diff < minDiff)
                {
                    minDiff = diff;
                    index = i;
                }
            }

            return results[index];
        }
        
        return 0;
    }