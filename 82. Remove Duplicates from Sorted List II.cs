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
        if(head==null || head.next==null){
            return head;
        }
        ListNode newHead = new ListNode(-1);
        newHead.next=head;
        ListNode p1 = newHead;
        ListNode p2 = head;
        
        while(p2!=null){
            bool test=false;
            while(p2.next!=null && p2.val==p2.next.val){
                test=true;
                p2=p2.next;
            }
            if(test){
                p2=p2.next;
                continue;
            }
            p1.next=p2;
            p1=p1.next;
            p2=p2.next;
        }
        p1.next=p2;
        return newHead.next;
    }
}