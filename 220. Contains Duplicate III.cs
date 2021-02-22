public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (nums == null || nums.Length < 1 || k <= 0 || t < 0)        
            return false;           

        var binarySearchTree = new SortedSet<long>();
        for (int i = 0; i < nums.Length; i++)
        {
            var visit = (long)nums[i];

            if (binarySearchTree.GetViewBetween(visit - t, visit + t).Count > 0)                
                return true;                

            binarySearchTree.Add(nums[i]);
               
            if (i >= k)
            {                    
                var node = nums[i - k];
                binarySearchTree.Remove(node);
            }
        }

        return false;
    }
}

//Java
class Solution {
    public boolean containsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (nums == null || nums.length < 1 || k <= 0) return false;
        int len = nums.length;
        TreeSet<Long> tree = new TreeSet<>();
        for (int i = 0; i < len; i++) {

            final Long ceil = tree.ceiling((long)nums[i] - t);
            final Long floor = tree.floor((long)nums[i] + t);
            if ((ceil != null && ceil <= nums[i] ) || (floor != null && floor >= nums[i])) {
                return true;
            }
            tree.add((long) nums[i]);
            //if (tree.size() == k) { WA [1] 1 1
            if (i >= k) {
                 tree.remove((long)nums[i - k]);
            }
        }
        return false;
    }
}