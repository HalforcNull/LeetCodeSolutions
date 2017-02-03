using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution162
    {
        public int FindPeakElement(int[] nums)
        {
            return FindPeakElementSub(nums, 0, nums.Length - 1);
        }

        private int FindPeakElementSub(int[] nums, int start, int end)
        {
            if(end == start)
            {
                return start;
            }

            if(end-start == 1)
            {
                if(nums[start]>nums[end])
                { return start; }
                else
                { return end; }
            }


            int Index = (end + start) / 2;
            int center = nums[Index];

            bool CenterIsGreaterThanLeft = Index == 0 || center > nums[Index - 1];
            bool CenterIsSmallerThanLeft =  center < nums[Index - 1];

            bool CenterIsGreaterThanRight = Index == end || center > nums[Index + 1];
            bool CenterIsSmallerThanRight = center < nums[Index + 1];

            if(CenterIsGreaterThanLeft && CenterIsGreaterThanRight)
            {
                return Index;
            }

            if (CenterIsSmallerThanLeft)
            {
                // current is decreasing, must have peak in left half
                return FindPeakElementSub(nums, start, Index);
            }

            if (CenterIsSmallerThanRight)
            {
                // current is increasing, must have peak in right half
                return FindPeakElementSub(nums, Index, end);
            }

            return -1;
        }
    }
}
