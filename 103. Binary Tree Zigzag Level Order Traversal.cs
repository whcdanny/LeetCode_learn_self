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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();;
        if(root==null){
            return result;
        }
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int direction = 1; // 0-right ;  - is left
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
            if (direction == 0)
            {
                level.Reverse();
                direction = 1;
            }
            else
                direction = 0;
            result.Add(level);
        }
        
        return result;
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
    vector<vector<int>> zigzagLevelOrder(TreeNode* root) {
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
        for(int i=1;i<result.size();i+=2){
            reverse(result[i].begin(),result[i].end());
        }
        return result;
    }
};