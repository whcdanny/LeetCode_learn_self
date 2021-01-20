public class Solution {
    public int FindMin(int[] nums) {
        return FindMin(nums, 0, nums.Length - 1);
    }
    private int FindMin(int[] nums, int left, int right)
    {
        if (left == right)
            return nums[left];
        if (right - left == 1)
            return Math.Min(nums[left], nums[right]);
        int mid = left + (right - left) / 2;
        if (nums[left] < nums[right])
            return nums[left];
        else if (nums[mid] > nums[left])
            return FindMin(nums, mid, right);
        else
            return FindMin(nums, left, mid);
    }
}

//Java
class Solution {
    public int findMin(int[] nums) {
        return findMin(nums, 0, nums.length - 1);
    }
    public int findMin(int[] num, int left, int right) {
	    if (left == right)
		    return num[left];
	    if ((right - left) == 1)
		    return Math.min(num[left], num[right]);
 
	    int middle = left + (right - left) / 2;
 
	    // not rotated
	    if (num[left] < num[right]) {
		    return num[left];
 
	    // go right side
	    } else if (num[middle] > num[left]) {
		    return findMin(num, middle, right);
 
	    // go left side
	    } else {
		    return findMin(num, left, middle);
	}
}
}