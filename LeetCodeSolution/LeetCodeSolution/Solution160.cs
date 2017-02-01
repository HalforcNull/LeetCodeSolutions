using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int countA, countB;

            countA = getNodeCount(headA);
            countB = getNodeCount(headB);

            int diff = countA - countB;
            int i;

            ListNode currentA = headA;
            ListNode currentB = headB;

            #region adjust the current node pointer of longer list. so both list has same "current to end" length
            if (diff > 0)
            {
                for (i = 0; i < diff; i++)
                {
                    currentA = currentA.next;
                }
            }
            else
            {
                for (i = diff; i < 0; i++)
                {
                    currentB = currentB.next;
                }
            }
            #endregion

            while (currentA != null && currentA != currentB)
            {
                currentA = currentA.next;
                currentB = currentB.next;
            }

            return currentA;
        }

        public int getNodeCount(ListNode head)
        {
            ListNode current = head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }
    }
}
