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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();;
        if(root==null){
            return result;
        }
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count != 0){
            List<int> level = new List<int>();
            int size = q.Count;
            for(int i=0;i<size;i++){
                TreeNode node = q.Dequeue();
                level.Add(node.val);
                if(node.left != null) 
                    q.Enqueue(node.left);
                if(node.right != null) 
                    q.Enqueue(node.right);                
            }
            result.Add(level);
        }
        var finalResult = (List<IList<int>>)result;
        finalResult.Reverse();

        return (IList<IList<int>>)finalResult;
            
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
    vector<vector<int>> levelOrderBottom(TreeNode* root) {
        vector<vector<int>> result;
        if(root==NULL){
            return result;
        }
        queue<TreeNode*> q;
        q.push(root);
        while(!q.empty()){
            vector<int> level;
            int size = q.size();
            for(int i=0;i<size;i++){
                TreeNode* node = q.front();
                q.pop();
                level.push_back(node->val);
                if(node->left){
                    q.push(node->left);
                }
                if(node->right){
                    q.push(node->right);
                }
            }
            result.push_back(level);
        }
        reverse(result.begin(),result.end());
        return result;
        
    }
};