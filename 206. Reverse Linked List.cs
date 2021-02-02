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
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next==null)
                return head;
        ListNode pre = head;
        ListNode p = head.next;
        pre.next = null;
        ListNode next;
        while (p != null)
        {
            next = p.next;
            p.next = pre;
            pre = p;
            p = next;
        }
        return pre;
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
public class Solution {
    public ListNode reverseList(ListNode head) {
        if(head==null){
            return head;
        }
        if(head.next==null){
            return head;
        }
        ListNode pre = head;
        ListNode p = head.next;
        pre.next=null;
        ListNode next;
        while(p!=null){
            next=p.next;
            p.next=pre;
            pre=p;
            p=next;
        }
        return pre;
    }
}