/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private int max = Int32.MinValue;
    public int MaxPathSum(TreeNode root) {
        if (root == null)
            return 0;
        maxSum(root);
        return max;
    }
    private int maxSum(TreeNode root)
    {
        if (root == null)
            return 0;
        int left = maxSum(root.left);
        int right = maxSum(root.right);

        int curMax = root.val;
        if (left > 0)
        {
            curMax += left;
        }
        if (right > 0)
        {
            curMax += right;
        }
        if (curMax > max)
        {
            max = curMax;
        }
        return Math.Max(root.val, Math.Max(root.val + left, root.val + right));            
    }
}

//Java
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    private int max = Integer.MIN_VALUE;
    public int maxPathSum(TreeNode root) {
        if(root == null){
            return 0;
        }
        maxSum(root);
        return max;
    }
    public int maxSum(TreeNode root){
        if(root == null){
            return 0;
        }
        int left=maxSum(root.left);
        int right=maxSum(root.right);
        
        int curMax=root.val;
        if(left>0){
            curMax+=left;
        }
        if(right>0){
            curMax+=right;
        }
        if(curMax>max){
            max=curMax;
        }
        return Math.max(root.val, Math.max(root.val+left, root.val+right));
    }
}