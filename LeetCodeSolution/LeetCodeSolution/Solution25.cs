using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution25
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if(head == null||head.next == null || k == 1 || k < 0)
            {
                return head;
            }

            int currentReverseLinkLength = 1;

            ListNode mainHead = null;
            ListNode mainTail = null;

            ListNode curentHeader = head;
            ListNode currentTail = head;
            ListNode pickedNode = head.next;

            while(pickedNode != null)
            {
                ListNode nextPickedNode = pickedNode.next;
                if(currentReverseLinkLength == 0)
                {
                    // the first node of the segement
                    // init header and tail for current segment
                    curentHeader = pickedNode;
                    currentTail = pickedNode;
                    currentReverseLinkLength++;
                    pickedNode = nextPickedNode;
                    continue;
                }


                currentTail.next = pickedNode.next;
                pickedNode.next = curentHeader;
                curentHeader = pickedNode;
                pickedNode = nextPickedNode;
                currentReverseLinkLength++;
                if (currentReverseLinkLength == k)
                {
                    // current segment is full
                    // connect with pre segment (if has) 
                    currentReverseLinkLength = 0;
                    if(mainHead == null)
                    { mainHead = curentHeader; }

                    if(mainTail == null)
                    { mainTail = currentTail; }
                    else
                    {
                        mainTail.next = curentHeader;
                        mainTail = currentTail;
                    }
                }
            }

            //TODO: if last segment is not a full segment, reverse it again.
            if(currentReverseLinkLength!=0)
            {
                pickedNode = curentHeader;
                currentTail = pickedNode;
                while(pickedNode!=null)
                {
                    ListNode nextPickedNode = pickedNode.next;
                    currentTail.next = pickedNode.next;
                    pickedNode.next = curentHeader;
                    curentHeader = pickedNode;
                    pickedNode = nextPickedNode;
                }

                //after reverse add this segment into main link
                if(mainTail != null)
                {
                    // this is not necessary if "k is a positive integer and is less than or equal to the length of the linked list. "
                    // the test case in Leetcode do have k > length one

                    mainTail.next = curentHeader;
                }
                else
                {
                    mainHead = curentHeader;
                }
                mainTail = currentTail; // this is not necessary
            }

            return mainHead;
        }
    }
}
