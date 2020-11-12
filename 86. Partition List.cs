/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        var newListNode = head;

        var lowX = new ListNode(-1);
        var highX = new ListNode(-1);
        var low = new ListNode(0);
        var high = new ListNode(0);

        lowX.next = low;
        highX.next = high;

        while (newListNode != null) {
            if (newListNode.val < x) {
                low.next = new ListNode(newListNode.val);
                low = low.next;
            }else{
                high.next = new ListNode(newListNode.val);
                high = high.next;
            }
            newListNode = newListNode.next;
        }
        low.next = highX.next.next;
        return lowX.next.next;
    }
}