/*Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.

If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).

The replacement must be in-place and use only constant extra memory.

Here are some examples. Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.

1,2,3 → 1,3,2
3,2,1 → 1,2,3
1,1,5 → 1,5,1*/

/*思路：检查递增 找出头与尾的位置*/

public class Solution {
    public void NextPermutation(int[] nums) {
       var i = nums.Length - 2;
        while (i >= 0 && nums[i + 1] <= nums[i])
        {
            i--;
        }

        if (i >= 0)
        {
            var j = nums.Length - 1;
            while (j >= 0 && nums[j] <= nums[i])
            {
                j--;
            }

            Swap(nums, i, j);
        }

        Reverse(nums, i + 1);
    }

    private void Swap(int[] nums, int i, int j)
    {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    private void Reverse(int[] nums, int start)
    {
        var i = start;
        var j = nums.Length - 1;

        while (i < j)
        {
            Swap(nums, i, j);
            i++;
            j--;
        }
    }     
}