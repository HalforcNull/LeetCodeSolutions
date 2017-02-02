using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution33
    {
        public int Search(int[] nums, int target)
        {
            if(nums.Length<4)
            {
                return TestLessThanFour(nums, 0, nums.Length-1, target);
            }

            return DivideAndTest(nums, 0, nums.Length - 1, target);

        }

        public int DivideAndTest(int[] nums, int head, int end, int target)
        {
            if(end-head < 3)
            {
                return TestLessThanFour(nums, head, end, target);
            }

            int middle = (end + head) / 2;

            if(nums[head] == target)
            {
                return head;
            }

            if(nums[middle] == target)
            {
                return middle;
            }

            if(nums[end] == target)
            {
                return end;
            }

            if (nums[head] < nums[middle] && nums[head] < target && nums[middle] > target     //not rotated
                || nums[head] > nums[middle] && (nums[head] < target || nums[middle] > target))  // rotated
            {
                //target is in first half
                return DivideAndTest(nums, head + 1, middle - 1, target);
            }

            return DivideAndTest(nums, middle + 1, end - 1, target);
        }

        private int TestLessThanFour(int[] nums, int head, int end, int target)
        {
            for(int i = head; i<= end; i++)
            {
                if(nums[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
