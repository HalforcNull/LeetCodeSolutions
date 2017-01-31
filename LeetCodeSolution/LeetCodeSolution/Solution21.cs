using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode header = null;
            ListNode prenode = null;
            ListNode current = null;

            if(l1 == null && l2 ==null)
            {
                return null;
            }

            while(l1!=null && l2!=null)
            {
                if(l1.val < l2.val)
                {
                    current = l1;
                    l1 = l1.next;
                }
                else
                {
                    current = l2;
                    l2 = l2.next;
                }

                if(header == null)
                {
                    header = current;
                }
                else
                {
                    prenode.next = current;
                }

                prenode = current;
            }

            ListNode tail = null;
            if(l1 == null)
            {
                tail = l2;
            }
            else
            {
                tail = l1;
            }

            if(prenode == null)
            {
                header = tail;
            }
            else
            {
                prenode.next = tail;
            }

            return header;
        }
    }

    



}
