using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    class Solution141
    {
        public class Solution
        {
            public bool HasCycle(ListNode head)
            {
                if(head == null)
                {
                    return false;
                }

                ListNode current = head.next;
                while(current!=null)
                {
                    if(current == head)
                    {
                        return true;
                    }

                    // if not using extra space, we need add some 'mark' on original node. 
                    // in my case, i simple point the next node of any tested node to head.
                    ListNode temp = current.next;
                    current.next = head;
                    current = temp;
                }

                return false;
            }
        }
    }
}
