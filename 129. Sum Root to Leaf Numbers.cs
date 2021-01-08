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
    public int SumNumbers(TreeNode root) {
        return dfs(root, 0);
    }
    private int dfs(TreeNode root, int sum)
    {
        if (root == null)
            return 0;
        if (root.left == null && root.right == null)
            return sum * 10 + root.val;
        return dfs(root.left,sum*10+root.val)+ dfs(root.right, sum * 10 + root.val);
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
    int sumNumbers(TreeNode* root) {
        return dfs(root,0);
    }
private:
    int dfs(TreeNode* root, int sum){
        if(root == nullptr){
            return 0;
        }
        if(root->left==nullptr && root->right==nullptr){
            return sum*10+root->val;
        }
        return dfs(root->left, sum*10+root->val)+dfs(root->right, sum*10+root->val);
    }
};