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
        if(head==null || head.next == null) return head;
        ListNode current = head.next;
        ListNode current2 = current.next;
        bool madeNull = false;
        while (current != null) {
            if (!madeNull) { 
                head.next = null;
                madeNull = true;
            }
            current.next = head;
            head = current;
            current = current2;
            if (current2 != null)
            {
                current2 = current2.next;
            }
        }
        return head;
    }
}