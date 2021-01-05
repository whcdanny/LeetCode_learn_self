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
        
        Node leftN = root.left;
        Node rightN = root.right;
        while(leftN != null){
            leftN.next = rightN;
            leftN = leftN.right;
            rightN = rightN.left;
        }
        Connect(root.left);
        Connect(root.right);
        return root;
    }
}