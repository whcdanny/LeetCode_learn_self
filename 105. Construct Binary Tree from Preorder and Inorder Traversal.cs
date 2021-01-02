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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int preLength = preorder.Length;
        int inLength = inorder.Length;
        return binaryTree(preorder, 0, preLength - 1, inorder, 0, inLength - 1);
    }
    private TreeNode binaryTree(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd)
    {
        if (preStart > preEnd || inStart > inEnd)
        {
            return null;
        }
        int rootVal = preorder[preStart];
        int rootIndex = 0;
        for (int i = inStart; i <= inEnd; i++)
        {
            if (inorder[i]== rootVal){
                rootIndex = i;
                break;
            }
        }
        int length = rootIndex - inStart;
        TreeNode root = new TreeNode(rootVal);
        root.left=binaryTree(preorder, preStart+1, preStart+length, inorder, inStart, rootIndex-1);
        root.right=binaryTree(preorder, preStart+length+1, preEnd, inorder, rootIndex+1, inEnd);
        return root;
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
    public TreeNode buildTree(int[] preorder, int[] inorder) {
        int preLength = preorder.length;
        int inLength = inorder.length;
        return binaryTree(preorder,0,preLength-1,inorder,0,inLength-1);
    }
    public TreeNode binaryTree(int[] pre, int preStart, int preEnd, int[] in, int inStart, int inEnd){
        if(preStart>preEnd || inStart>inEnd){
            return null;
        }
        int rootVal=pre[preStart];
        int rootIndex=0;
        for(int i=inStart; i<=inEnd; i++){
            if(in[i]==rootVal){
                rootIndex=i;
                break;
            }
        }
        int length = rootIndex-inStart;
        TreeNode root = new TreeNode(rootVal);
        root.left=binaryTree(pre,preStart+1,preStart+length, in,inStart,rootIndex-1);
        root.right=binaryTree(pre,preStart+length+1,preEnd, in,rootIndex+1,inEnd);
        return root;
    }
}