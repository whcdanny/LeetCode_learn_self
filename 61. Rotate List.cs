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
    public ListNode RotateRight(ListNode head, int k) {
        if (head?.next == null) return head;
        if (k <= 0) return head; 

        var l = GetLenght(head);

        k = k % l;
        if (k == l || k == 0) return head;

        var headCopy = head;

        var prev = head;
        while (l > 0)
        {
            if (k == l)
            {
                prev.next = null;
                break;
            }

            prev = head;
            head = head.next;
            l--;
        }

        var newHead = head;

        while (head.next != null)
        {
            head = head.next;
        }

        head.next = headCopy;

        return newHead;
    }
    private int GetLenght(ListNode node)
    {
        var l = 0;
        while (node != null)
        {
            l++;
            node = node.next;
        }

        return l;
    }
}