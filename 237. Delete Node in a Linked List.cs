/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        if(node==null || node.next==null){
            return;
        }
        if(node.next!=null){
            int value=node.next.val;
            node.val=value;
            node.next=node.next.next;
        }
    }
}

//Java
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
class Solution {
    public void deleteNode(ListNode node) {
        if(node==null || node.next==null){
            return;
        }
        if(node.next!=null){
            int value=node.next.val;
            node.val=value;
            node.next=node.next.next;
        }
    }
}