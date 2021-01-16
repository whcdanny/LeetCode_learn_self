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
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        Stack<TreeNode> s = new Stack<TreeNode>();
        if (root != null)
            s.Push(root);
        while (s.Count != 0)
        {
            TreeNode p = s.Pop();
            res.Add(p.val);
            if (p.right != null)
                s.Push(p.right);
            if (p.left != null)
                s.Push(p.left);
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
    vector<int> preorderTraversal(TreeNode* root) {
        vector<int> result;
        stack<const TreeNode *> s;
        if(root != nullptr){
            s.push(root);
        }
        while(!s.empty()){
            const TreeNode *p = s.top();
            s.pop();
            result.push_back(p->val);
            if(p->right != nullptr){
                s.push(p->right);
            }
            if(p->left != nullptr){
                s.push(p->left);
            }
        }
        return result;
    }
};