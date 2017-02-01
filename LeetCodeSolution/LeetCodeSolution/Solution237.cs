using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution237
    {
        public void DeleteNode(ListNode node)
        {
            ListNode t = node.next;

            if (t == null)
            { return; }

            node.val = t.val;
            node.next = t.next;

            return;
        }
    }
}
