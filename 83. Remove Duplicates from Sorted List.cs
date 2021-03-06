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
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null)
        {
            return null;
        }
        
        var prev = head;
        var current = prev.next;

        while (current != null)
        {
            if (current.val == prev.val)
            {
                prev.next = current.next;
            }
            else
            {
                prev = current;
            }
            
            current = current.next;
        }

        return head;
    }
}