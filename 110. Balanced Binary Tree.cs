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
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
            return true;
        int deepLeft = getDeep(root.left,1);
        int deepRight = getDeep(root.right,1);

        if (Math.Abs(deepLeft - deepRight) > 1)
            return false;
        else
            return IsBalanced(root.left) && IsBalanced(root.right);
        }

    private int getDeep(TreeNode root, int deep)
    {
        if (root == null)
            return deep;
        return Math.Max(getDeep(root.left, deep + 1), getDeep(root.right, deep + 1));
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
    public boolean isBalanced(TreeNode root) {
        if(root==null){
            return true;
        }
        int depLeft=getDep(root.left,1);
        int depRight=getDep(root.right,1);
        
        if(Math.abs(depLeft-depRight)>1){
            return false;
        }
        else{
            return isBalanced(root.left)&&isBalanced(root.right);
        }
    }
    private int getDep(TreeNode tree, int dep){
        if(tree==null){
            return dep;
        }
        return Math.max(getDep(tree.left, dep+1),getDep(tree.right, dep+1));
    }
}