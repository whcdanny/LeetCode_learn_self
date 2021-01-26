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
public class BSTIterator {

    public Stack<TreeNode> stack = new Stack<TreeNode>();
    public BSTIterator(TreeNode root)
    {
        push(root);
    }

    private void push(TreeNode root)
    {
        while(root != null)
        {
            stack.Push(root);
            root = root.left;
        }
    }

    public int Next()
    {
        TreeNode tnode = stack.Pop();
        push(tnode.right);
        return tnode.val;
    }

    public bool HasNext()
    {
        if (stack.Count > 0)
            return true;
        else
            return false;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
 
 
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
class BSTIterator {
    
    private Stack<TreeNode> stack = new Stack<TreeNode>();

    public BSTIterator(TreeNode root) {
        pushAll(root);
    }
    
    public int next() {
        TreeNode tnode = stack.pop();
        pushAll(tnode.right);
        return tnode.val;
    }
    
    public boolean hasNext() {
        return !stack.isEmpty();
    }
    private void pushAll(TreeNode node){
        while(node != null){
            stack.push(node);
            node = node.left;
        }
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.next();
 * boolean param_2 = obj.hasNext();
 */