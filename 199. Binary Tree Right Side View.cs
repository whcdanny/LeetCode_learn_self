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
    public IList<int> RightSideView(TreeNode root) {
        IList<int> res = new List<int>();
        helper(root, res, 0);
        return res;
    }
    private void helper(TreeNode root, IList<int> res, int dep)
    {
        if (root == null)
            return;
        if (dep == res.Count)
            res.Add(root.val);
        helper(root.right, res, dep + 1);
        helper(root.left, res, dep + 1);
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
    public List<Integer> rightSideView(TreeNode root) {
        List<Integer> res = new ArrayList<>();
        helper(root, res, 0);
        return res;
    }
    public void helper(TreeNode root, List<Integer> res, int depth) {
        if(root == null){
            return ;
        }
        if(depth == res.size()) {
            res.add(root.val);
        }
        helper(root.right, res, depth + 1);
        helper(root.left, res, depth + 1);
    }
}