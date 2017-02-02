using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution445
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int FirstLength = CountLinkLength(l1);
            int SecondLength = CountLinkLength(l2);

            ListNode l1Pointer = l1;
            ListNode l2Pointer = l2;

            if (FirstLength > SecondLength)
            {
                int diff = FirstLength - SecondLength;
                return fetchResult(l1, l2, diff);
            }
            else
            {
                int diff = SecondLength - FirstLength;
                return fetchResult(l2, l1, diff);
            }
        }

        private ListNode fetchResult(ListNode l1, ListNode l2, int diff)
        {
            int one;
            ListNode currentResult = AddTwoUnequal(l1, l2, diff, out one);

            if(one !=0)
            {
                ListNode head = new ListNode(one);
                head.next = currentResult;
                return head;
            }
            else
            {
                return currentResult;
            }
        }
        
        public int CountLinkLength(ListNode head)
        {
            int result = 0;
            ListNode current = head;
            while(current != null)
            {
                result++;
                current = current.next;
            }

            return result;
        }

        /// <summary>
        /// l1 and l2 may unequal
        /// l1 must longer or equal to l2
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <param name="ten"></param>
        /// <returns></returns>
        public ListNode AddTwoUnequal(ListNode l1, ListNode l2, int diff, out int ten)
        {
            if(l1==null)
            { ten = 0; return null; }

            if(diff == 0)
            {
                return AddTwoEqualNode(l1, l2, out ten);
            }

            int one;
            diff--;
            ListNode nextResult = AddTwoUnequal(l1.next, l2, diff, out one);

            int rawResult = l1.val + one;
            ListNode current = new ListNode(rawResult % 10);
            ten = rawResult / 10;
            current.next = nextResult;

            return current;
        }


        /// <summary>
        /// l1 and l2 must be same length
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <param name="ten"></param>
        /// <returns></returns>
        public ListNode AddTwoEqualNode( ListNode l1, ListNode l2, out int ten)
        {
            if(l1==null)
            { ten = 0; return null; }

            int one;
            ListNode nextResult = AddTwoEqualNode(l1.next, l2.next, out one);

            int rawResult = l1.val + l2.val + one;
            ListNode current = new ListNode(rawResult % 10) ;
            ten = rawResult / 10;
            current.next = nextResult;

            return current;
        }
    }
    
}
