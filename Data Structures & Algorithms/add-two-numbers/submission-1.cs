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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode sum = new ListNode(0);
        ListNode res = sum;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0) {
            int v1 = l1?.val ?? 0;
            int v2 = l2?.val ?? 0;

            int s = v1 + v2 + carry;

            carry = s / 10;
            s = s % 10;

            sum.next = new ListNode(s);
            sum = sum.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return res.next;
    }
}
