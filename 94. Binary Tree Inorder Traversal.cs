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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> nums = new List<int>();

        InorderTraversal(root, ref nums);
        return nums;
    }
    public void InorderTraversal(TreeNode root, ref IList<int> nums)
    {
        if (root == null)
        {
            return;
        }

        if (root.left != null)
        {
            InorderTraversal(root.left, ref nums);
        }

        nums.Add(root.val);

        if (root.right != null)
        {
            InorderTraversal(root.right, ref nums);
        }
    }
}