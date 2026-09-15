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
        ListNode prev = null;
        ListNode next = null;
        ListNode curr = head;
        int t = 0;
        ListNode cur = head;
        while (cur != null) {
            t++;
            cur = cur.next;
        }

        if(t == n) return head.next;
        var count = t-n;
        while(count > 0){
            
            if(curr == null){
                prev = null;
                curr = head;
            }
            else{
                prev = curr;
                curr = curr.next;
            }

            if(curr == null){
                next = null;
            }
            else{
                next = curr.next;
            }
            
            count--;
        }

        prev.next = next;
        return head;
    }
}
