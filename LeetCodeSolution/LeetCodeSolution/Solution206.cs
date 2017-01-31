using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution206
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            { return null; }

            if (head.next == null)
            {
                return head;
            }

            return Reverse(head.next, head);
        }

        private ListNode Reverse(ListNode current, ListNode prenode)
        {
            prenode.next = null;

            if (current.next == null)
            {
                current.next = prenode;
                return current;
            }

            ListNode newHead = Reverse(current.next, current);

            current.next = prenode;

            return newHead;
        }
    }


    /*
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    */
}
