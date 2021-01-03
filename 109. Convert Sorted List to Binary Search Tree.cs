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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head)
    {
        if (head == null)
            return null;
        ListNode cur = head;
        int count = 0;
        while (cur != null)
        {
            cur = cur.next;
            count++;
        }
        List<ListNode> list = new List<ListNode>();
        list.Add(head);
        return build(list, 0, count - 1);
    }

    private TreeNode build(List<ListNode> list, int left, int right)
    {
        if (left > right)
            return null;
        int mid = (left + right) / 2;
        TreeNode rootleft = build(list, left, mid - 1);
        TreeNode root = new TreeNode(list[0].val);
        root.left = rootleft;
        list.Insert(0, list[0].next);
        root.right = build(list, mid + 1, right);            
        return root;
    }
}

//Java
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public TreeNode sortedListToBST(ListNode head) {
        if(head==null){
            return null;
        }
        ListNode cur=head;
        int count=0;
        while(cur!=null){
            cur=cur.next;
            count++;
        }
        ArrayList<ListNode> list = new ArrayList<ListNode>();
        list.add(head);
        return build(list, 0, count-1);
    }
    private TreeNode build(ArrayList<ListNode> list, int left, int right){
        if(left>right){
            return null;
        }
        int m=(left+right)/2;
        TreeNode rootleft = build(list,left,m-1);
        TreeNode root = new TreeNode(list.get(0).val);
        root.left = rootleft;
        list.set(0,list.get(0).next);
        root.right=build(list, m+1,right);
        return root;
    }
}