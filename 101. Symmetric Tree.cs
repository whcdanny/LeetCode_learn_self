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
    public bool IsSymmetric(TreeNode root) {
        if(root==null){
            return true;
        }
        return symmetric(root.left, root.right);
    }
    public bool symmetric(TreeNode p,TreeNode q){
        if(p==null&&q==null){
            return true;
        }
        else if(p==null&&q!=null){
            return false;
        }
        else if(p!=null&&q==null){
            return false;
        }
        else if(p.val!=q.val){
            return false;
        }
        else{
            return symmetric(p.left,q.right) && symmetric(p.right,q.left);
        }
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
    bool isSymmetric(TreeNode* root) {
        if(!root){
            return true;
        }
        return symmetric(root->left, root->right);
    }
    bool symmetric(TreeNode* p,TreeNode* q){
        if(!p&&!q){
            return true;
        }
        else if(!p&&q){
            return false;
        }
        else if(p&&!q){
            return false;
        }
        else if(p->val!=q->val){
            return false;
        }
        else{
            return symmetric(p->left,q->right) && symmetric(p->right,q->left);
        }
    }
};