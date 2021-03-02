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
    public bool IsPalindrome(ListNode head) {
        LinkedList<int> nodeVal = new LinkedList<int>();
        if (head == null || head.next == null)
        {
            return true;
        }
        ListNode slow = head;
        ListNode fast = head;
        nodeVal.AddFirst(slow.val);
        while (fast.next != null && fast.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            nodeVal.AddFirst(slow.val);
        }

        ListNode cur = slow;
        if (fast.next != null)
        {
            cur = slow.next;
        }
        int i = 0;
        while (cur != null)
        {
            if (nodeVal.ElementAt(i) != cur.val)
            {
                return false;
            }
            cur = cur.next;
            i++;
        }
        return true;
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
    public boolean isPalindrome(ListNode head) {
        LinkedList<Integer> nodeVal=new LinkedList<>();
        if(head==null || head.next==null){
            return true;
        }
        ListNode slow = head;
        ListNode fast = head;
        nodeVal.add(0,slow.val); 
        while(fast.next!=null && fast.next.next!=null){
            fast = fast.next.next;
            slow = slow.next;
            nodeVal.add(0,slow.val); 
        }
        
        ListNode cur = slow;
        if(fast.next!=null){
            cur=slow.next;
        }
        int i=0;
        while(cur!=null){
            if(nodeVal.get(i)!=cur.val){
                return false;
            }
            cur=cur.next;
            i++;
        }
        return true;
        
    }
}