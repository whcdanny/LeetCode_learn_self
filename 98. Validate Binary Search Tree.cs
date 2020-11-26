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
    public bool IsValidBST(TreeNode root) {
        return BST(root, long.MinValue, long.MaxValue);
    }
    private bool BST(TreeNode root, long minVal, long maxVal)
    {
        if(root == null) return true;

        if(root.val >= maxVal || root.val <= minVal) return false;

        return BST(root.left, minVal, root.val) && BST(root.right, root.val, maxVal);
    }
}


//C++
/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */
class Solution {
public:
    bool isValidBST(TreeNode* root) {
        return bst(root, LONG_MIN, LONG_MAX);
    }
    bool bst(TreeNode *root, long min, long max){
        if(!root){
            return true;
        }
        if(root->val<=min||root->val>=max){
            return false;
        }
        return bst(root->left, min, root->val)&&bst(root->right, root->val, max);
    }
};