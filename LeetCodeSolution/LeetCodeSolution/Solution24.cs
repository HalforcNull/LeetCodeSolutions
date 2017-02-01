using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution24
    {
        public ListNode SwapPairs(ListNode head)
        {
            if( head == null || head.next == null)
            { return head; }

            ListNode newHeader = head.next;
            head.next = newHeader.next;
            newHeader.next = head;
            

            ListNode tail = head;

            ListNode current = tail.next;
            while( current != null )
            {
                ListNode currentNext = current.next;
                if(currentNext == null)
                {
                    //reach last node (single)
                    return newHeader;
                }

                //swap 2 nodes
                current.next = currentNext.next;
                currentNext.next = current;

                //change tail connection
                tail.next = currentNext;

                //modify tail and current, ready for next loop
                tail = current;
                current = tail.next;
            }

            //reach last node (double)
            return newHeader;
        }
    }
}
