using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution41
    {
        public int FirstMissingPositive(int[] nums)
        {
            if(nums.Length == 0)
            { return 1; }

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i]--;
            }

            for( int i =0;i<nums.Length;i++)
            {
                freshMove(ref nums, i);
            }

            for(int i =0;i<nums.Length;i++)
            {
                if(i!=nums[i])
                {
                    return i + 1;
                }
            }

            return nums.Length + 1;
        }

        private void freshMove(ref int[] nums, int position)
        {
            int value = nums[position];

            if (value == position)
            {
                return;
            }
            else
            {
                nums[position] = -1;
            }

            swap(ref nums, value);
        }

        private void swap( ref int[] nums, int position)
        {
            if(position < 0 || position >= nums.Length)
            { return; }


            int value = nums[position];

            if(value == position)
            {
                return;
            }
            else
            {
                nums[position] = position;
            }
            
            swap(ref nums, value);
        }
    }
}
