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
    public void Flatten(TreeNode root) {
        if (root == null)
            return;
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);

        while (s.Count != 0)
        {
            TreeNode cur = s.Pop();
            if (cur.left != null)
            {
                TreeNode next = cur.left;
                while (next.right != null)
                {
                    next = next.right;
                }
                next.right = cur.right;
                cur.right = cur.left;
                cur.left = null;
            }
            if (cur.right != null)
            {
                s.Push(cur.right);
            }
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
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    void flatten(TreeNode* root) {
        if(!root)
            return;
        stack<TreeNode*> s;
        s.push(root);
        
        while(!s.empty()){
            TreeNode *cur = s.top();
            s.pop();
            if(cur->left){
                TreeNode *next=cur->left;
                while(next->right){
                    next=next->right;
                }
                next->right=cur->right;
                cur->right=cur->left;
                cur->left=NULL;
            }
            if(cur->right){
                s.push(cur->right);
            }
        }
    }
};