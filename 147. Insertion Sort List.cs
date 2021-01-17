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
    public ListNode InsertionSortList(ListNode head) {
        if (head == null)
        {
            return null;
        }
        ListNode list = new ListNode(0);
        ListNode pre = list;
        ListNode cur = head;
        while (cur != null)
        {
            ListNode next = cur.next;
            pre = list;
            while (pre.next != null && pre.next.val <= cur.val)
            {
                pre = pre.next;
            }
            cur.next = pre.next;
            pre.next = cur;
            cur = next;
        }
        return list.next;
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
    public ListNode insertionSortList(ListNode head) {
        if(head==null){
            return null;
        }
        ListNode list = new ListNode(0);
        ListNode pre = list;
        ListNode cur = head;
        while(cur!=null){
            ListNode next = cur.next;
            pre = list;
            while(pre.next!=null && pre.next.val<=cur.val){
                pre = pre.next;
            }
            cur.next = pre.next;
            pre.next = cur;
            cur = next;
        }
        return list.next;
    }
}