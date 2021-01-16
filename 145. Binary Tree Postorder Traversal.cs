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
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        Stack<TreeNode> s = new Stack<TreeNode>();
        if (root == null)
            return res;
        s.Push(root);
            
        while (s.Count != 0)
        {
            TreeNode p = s.Pop();
            res.Insert(0, p.val);
            if (p.left != null)
                s.Push(p.left);
            if (p.right != null)
                s.Push(p.right);            
        }
        return res;
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
    vector<int> postorderTraversal(TreeNode* root) {
        vector<int> result;
        stack<TreeNode*> stack;
        if(root==NULL){
            return result;
        }
        stack.push(root);
        TreeNode* cur=root;
        TreeNode* pre=NULL;
        while(!stack.empty()){
            cur=stack.top();
            if((cur->left==NULL&&cur->right==NULL)||((pre!=NULL)&&(pre==cur->left||pre==cur->right))){
                result.push_back(cur->val);
                stack.pop();
                pre=cur;
            }
            else{
                if(cur->right!=NULL){
                    stack.push(cur->right);
                }
                if(cur->left!=NULL){
                    stack.push(cur->left);
                }
            }
        }
        return result;
    }
};