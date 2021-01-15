/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null)
        {
            return head;
        }
        Node node = head;
        while (node != null)
        {
            Node newNode = new Node(node.val);
            newNode.next = node.next;
            node.next = newNode;
            node = newNode.next;
        }
        node = head;
        while (node != null)
        {
            if (node.random != null)
            {
                node.next.random = node.random.next;
            }
            node = node.next.next;
        }
        Node newHead = head.next;
        node = head;
        while (node != null)
        {
            Node newNode = node.next;
            node.next = newNode.next;
            if (newNode.next != null)
            {
                newNode.next = newNode.next.next;
            }
            node = node.next;
        }
        return newHead;
    }
}

//Java
/**
 * Definition for singly-linked list with a random pointer.
 * class RandomListNode {
 *     int label;
 *     RandomListNode next, random;
 *     RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode copyRandomList(RandomListNode head) {
        if(head ==null){
            return head;
        }
        RandomListNode node = head;
        while(node!=null){
            RandomListNode newNode = new RandomListNode(node.label);
            newNode.next = node.next;
            node.next = newNode;
            node = newNode.next;
        }
        node = head;
        while(node!=null){
            if(node.random != null){
                node.next.random = node.random.next;
            }
            node = node.next.next;
        }
        RandomListNode newHead = head.next;
        node = head;
        while(node!=null){
            RandomListNode newNode = node.next;
            node.next = newNode.next;
            if(newNode.next!=null){
                newNode.next = newNode.next.next;
            }
            node=node.next;
        }
        return newHead;
    }
}