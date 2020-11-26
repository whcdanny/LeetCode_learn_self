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
    TreeNode pre;
    TreeNode first;
    TreeNode second;
    public void RecoverTree(TreeNode root) {
        pre=null;
        first=null;
        second=null;
        inorder(root);
        if(first!=null && second!=null){
            int tmp=first.val;
            first.val=second.val;
            second.val=tmp;
        }
    }
    public void inorder(TreeNode root){
        if(root==null){
            return;
        }
        inorder(root.left);
        if(pre==null){
            pre=root;
        }
        else{
            if(pre.val>root.val){
                if(first==null){
                    first=pre;
                }
                second=root;
            }
            pre=root;
        }
        inorder(root.right);
    }
}


//Java
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    TreeNode pre;
    TreeNode first;
    TreeNode second;
    public void recoverTree(TreeNode root) {
        pre=null;
        first=null;
        second=null;
        inorder(root);
        if(first!=null && second!=null){
            int tmp=first.val;
            first.val=second.val;
            second.val=tmp;
        }
    }
    public void inorder(TreeNode root){
        if(root==null){
            return;
        }
        inorder(root.left);
        if(pre==null){
            pre=root;
        }
        else{
            if(pre.val>root.val){
                if(first==null){
                    first=pre;
                }
                second=root;
            }
            pre=root;
        }
        inorder(root.right);
    }
}