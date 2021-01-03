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
    public IList<IList<int>> PathSum(TreeNode root, int sum)
    {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> cur = new List<int>();
        sumPath(root, sum, cur, res);
        return res;
    }

    private void sumPath(TreeNode root, int sum, List<int> cur, IList<IList<int>> res)
    {
        if (root == null)
            return;
        cur.Add(root.val);
        if (root.left == null && root.right == null)
        {
            if (sum == root.val)
            {
                res.Add(new List<int>(cur));                     
            }                
        }
        sumPath(root.left, sum - root.val, cur, res);
        sumPath(root.right, sum - root.val, cur, res);
        cur.RemoveAt(cur.Count - 1);
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
    vector<vector<int>> pathSum(TreeNode* root, int sum) {
        vector<vector<int>> result;
        vector<int> cur;
        sumPath(root, sum, cur, result);
        return result;
    }
private: 
    void sumPath(TreeNode* root, int sum, vector<int> &cur, vector<vector<int>> &result){
        if(root==nullptr){
            return;
        }
        cur.push_back(root->val);
        if(root->left==nullptr && root->right==nullptr){
            if(sum==root->val){
                result.push_back(cur);
            }
        }
        sumPath(root->left, sum-root->val, cur, result);
        sumPath(root->right, sum-root->val, cur, result);
        cur.pop_back();
    }
};