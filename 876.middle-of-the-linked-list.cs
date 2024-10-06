/*
 * @lc app=leetcode id=876 lang=csharp
 *
 * [876] Middle of the Linked List
 */

// @lc code=start
/**
 * Definition for singly-linked list.

 */
public class Solution876 {
    public ListNode MiddleNode(ListNode head) {
        var linkedListLength = LinkedListLength(head);
        var middle = linkedListLength / 2 + 1;
        var index = 1;
        while (head.next != null)
        {
            if (middle == index) {
                return head;
            }
            head = head.next;
            index++;
        }
        return head;
    }

    static int LinkedListLength(ListNode head) {
        var count = 1;
        while (head.next != null)
        {
            count++;
            head = head.next;
        }
        return count;
    }
}

public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }

// @lc code=end

