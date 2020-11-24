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
    public IList<TreeNode> GenerateTrees(int n) {
        if(n==0)
            return new List<TreeNode>();
        return generateTrees(1, n);
    }
    public IList<TreeNode> generateTrees(int start, int end) {
        IList<TreeNode> list = new List<TreeNode>();
 
        if (start > end) {
            list.Add(null);
            return list;
        }
 
        for (int i = start; i <= end; i++) {
            IList<TreeNode> lefts = generateTrees(start, i - 1);
            IList<TreeNode> rights = generateTrees(i + 1, end);
            
            foreach (TreeNode l in lefts) {
                foreach (TreeNode r in rights) {
                    TreeNode node = new TreeNode(i);
                    node.left = l;
                    node.right = r;
                    list.Add(node);
                }
            }
        }
 
        return list;    
    }
}