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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        return  RemoveNRecc(head, ref n);
    }

    private ListNode RemoveNRecc(ListNode head, ref int n){
        if(head == null){
            return null;
        }

        head.next = RemoveNRecc(head.next, ref  n);
        n--;
        if(n == 0) return head.next;
        return head;
    }
}
