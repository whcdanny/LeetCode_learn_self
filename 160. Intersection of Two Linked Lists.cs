/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null) return null;
        ListNode h1 = headA;
        ListNode h2 = headB;
        int count1 = 1, count2 = 1;
        while (h1.next != null)
        {
            count1++;
            h1 = h1.next;
        }
        while (h2.next != null)
        {
            count2++;
            h2 = h2.next;
        }
        if (h1 != h2) return null;
        else
        {
            int count = Math.Abs(count1 - count2);
            if (count2 > count1)
            {
                h1 = headB;
                h2 = headA;
            }
            else
            {
                h1 = headA;
                h2 = headB;
            }
            while ((count--) > 0)
            {
                h1 = h1.next;
            }
            while (h1 != null && h2 != null && h1 != h2)
            {
                h1 = h1.next;
                h2 = h2.next;
            }
            return h1;
        }
    }
}

//Java
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode getIntersectionNode(ListNode headA, ListNode headB) {
        if(headA == null ||headB == null)return null;  
        ListNode h1 = headA;  
        ListNode h2 = headB;  
        int count1 = 1, count2 = 1;  
        while(h1.next != null){  
            count1++;  
            h1 = h1.next;  
        }  
        while(h2.next != null){  
            count2++;  
            h2 = h2.next;  
        }  
        if(h1 != h2) return null;  
        else{  
            int count = Math.abs(count1 - count2);  
            if(count2 > count1){  
                h1 = headB;  
                h2 = headA;   
            }  
            else{  
                h1 = headA;  
                h2 = headB;  
            }  
            while((count--) > 0){  
                h1 = h1.next;  
            }  
            while(h1 != null&&h2 != null && h1 != h2){  
                h1 = h1.next;  
                h2 = h2.next;  
            }  
            return h1; 
        }
    }
}