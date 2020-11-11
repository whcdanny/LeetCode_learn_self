public class Solution {
    public bool Search(int[] nums, int target) {
        bool res = false;
        if(nums.Length == 0)
            return false;
        foreach(int i in nums){
            if(i==target){
                res = true;
                break;
            }
        }
        return res;
    }
}