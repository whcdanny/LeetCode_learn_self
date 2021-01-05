/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if(root == null)
            return root;
        
        Node node = root.next;
        Node nextNode = null;
        while(node != null && nextNode == null){
            if(node.left != null){
                nextNode = node.left;
                break;
            }
            if(node.right != null){
                nextNode = node.right;
                break;
            }
            node = node.next;
        }
        
        if(root.right != null)
            root.right.next = nextNode;
        if(root.left != null)
            root.left.next = root.right == null ? nextNode : root.right;
        
        Connect(root.right);
        Connect(root.left);
        return root;
    }
}