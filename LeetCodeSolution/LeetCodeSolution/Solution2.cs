using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddCurrent(l1, l2, 0);
        }

        private ListNode AddCurrent(ListNode l1, ListNode l2, int CarryOver)
        {
            int raw = CarryOver ;
            ListNode next1, next2, nextNode;
            if(l1 != null)
            {
                raw += l1.val;
                next1 = l1.next;
            }
            else
            {
                next1 = null;
            }

            if (l2 != null)
            {
                raw += l2.val;
                next2 = l2.next;
            }
            else
            {
                next2 = null;
            }

            ListNode currentNode = new ListNode(raw % 10);

            if(next1!=null || next2!=null || raw/10 != 0)
            {
                currentNode.next = AddCurrent(next1, next2, raw / 10);
                return currentNode;
            }
            else
            {
                currentNode.next = null;
                return currentNode;
            }
        }
    }

    
}
