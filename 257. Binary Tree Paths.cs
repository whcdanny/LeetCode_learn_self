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
    public IList<string> BinaryTreePaths(TreeNode root) {
        List<string> res = new List<string>();
        if (root == null)
            return res;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        Stack<string> track = new Stack<string>();
        stack.Push(root);
        track.Push("" + root.val);
        while (stack.Count!=0)
        {
            TreeNode cur = stack.Pop();
            string curPath = track.Pop();
            if (cur.left == null && cur.right == null)
            {
                res.Add(curPath);
            }
            else
            {
                if (cur.right != null)
                {
                    stack.Push(cur.right);
                    track.Push(curPath + "->" + cur.right.val);
                }
                if (cur.left != null)
                {
                    stack.Push(cur.left);
                    track.Push(curPath + "->" + cur.left.val);
                }
            }
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
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    vector<string> result;
    char buffer[32];
    
    vector<string> binaryTreePaths(TreeNode* root) {
        string s;
        
        if(root == NULL)
            return result;
            
        find_path_string(root, s);
        
        return result;
    }
    void find_path_string(TreeNode* root, string path){
        
        if(root->left == NULL && root->right == NULL){
            sprintf(buffer, "%d", root->val);
            path = path + buffer;
            result.push_back(path);
            return ;
        }
        
        sprintf(buffer, "%d->", root->val);
        path += buffer;
        
        if(root->left != NULL){
            find_path_string(root->left, path);
        }
        
        if(root->right != NULL){
            find_path_string(root->right, path);
        }
        
        return ;
    }
};

//Java
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public List<String> binaryTreePaths(TreeNode root) {
        List<String> res = new LinkedList<String>();
        if (root == null)
            return res;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        Stack<String> track = new Stack<String>();
        stack.push(root);
        track.push("" + root.val);
        while (!stack.isEmpty()) {
            TreeNode cur = stack.pop();
            String curPath = track.pop();
            if (cur.left == null && cur.right == null) {
                res.add(curPath);
            } else {
                if (cur.right != null) {
                    stack.push(cur.right);
                    track.push(curPath + "->" + cur.right.val);
                }
                if (cur.left != null) {
                    stack.push(cur.left);
                    track.push(curPath + "->" + cur.left.val);
                }
            }
        }
        return res;
    }
}