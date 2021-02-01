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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode newList = new ListNode();
        newList.next = head;
        ListNode cur = newList;
        while (cur.next != null)
        {
            if (cur.next.val == val)
            {
                cur.next = cur.next.next;
            }
            else
                cur = cur.next;
        }
        return newList.next;
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
    public ListNode removeElements(ListNode head, int val) {
        ListNode newList = new ListNode(0);
        newList.next=head;
        ListNode cur = newList;
        while(cur.next!=null){
            if(cur.next.val==val){
                cur.next=cur.next.next;
            }
            else{
                cur=cur.next;
            }
        }
        return newList.next;
        
    }
}