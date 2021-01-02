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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        int postLength = postorder.Length;
        int inLength = inorder.Length;
        return binaryTree(inorder, 0, inLength - 1, postorder, postLength - 1);
    }
    private TreeNode binaryTree(int[] inorder, int inStart, int inEnd, int[] postorder, int postEnd)
    {
        if (postEnd < 0 || inStart > inEnd)
        {
            return null;
        }
        int rootVal = postorder[postEnd];
        int rootIndex = 0;
        for (int i = inStart; i <= inEnd; i++)
        {
            if (inorder[i]== rootVal){
                rootIndex = i;
                break;
            }
        }
        //int length = rootIndex - inStart;
        TreeNode root = new TreeNode(rootVal);
        root.left=binaryTree(inorder, inStart, rootIndex-1, postorder, postEnd - (inEnd - rootIndex)-1);
        root.right=binaryTree(inorder, rootIndex + 1, inEnd, postorder, postEnd-1);
        return root;
    }
}