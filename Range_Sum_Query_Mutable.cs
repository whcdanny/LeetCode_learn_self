/*Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.

The update(i, val) function modifies nums by updating the element at index i to val.

Example:

Given nums = [1, 3, 5]

sumRange(0, 2) -> 9
update(1, 2)
sumRange(0, 2) -> 8
*/

public class NumArray {

    public int[] list;
    public NumArray(int[] nums) {
        list = nums;
    }
    
    public void Update(int i, int val) {
        list[i] = val;
    }
    
    public int SumRange(int i, int j) {
        int sum = 0 ;
        for(int s = i; s<=j; s++){
            sum += list[s];
        }
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(i,val);
 * int param_2 = obj.SumRange(i,j);
 */