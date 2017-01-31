using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution138
    {
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            if (head == null)
            {
                return null;
            }

            Dictionary<RandomListNode, RandomListNode> OriginalToNew = new Dictionary<RandomListNode, RandomListNode>();

            DeepCopy(head, OriginalToNew);
            return OriginalToNew[head];
        }

        public void DeepCopy(RandomListNode currentOld, Dictionary<RandomListNode, RandomListNode> O2N)
        {
            if (O2N.ContainsKey(currentOld))
            {
                return;
            }

            RandomListNode currentNew = new RandomListNode(currentOld.label);
            O2N.Add(currentOld, currentNew);

            if (currentOld.next != null)
            {
                DeepCopy(currentOld.next, O2N);
                currentNew.next = O2N[currentOld.next];
            }
            else
            {
                currentNew.next = null;
            }

            if (currentOld.random != null)
            {
                DeepCopy(currentOld.random, O2N);
                currentNew.random = O2N[currentOld.random];
            }
            else
            {
                currentNew.random = null;
            }
            return;
        }
    }
}
