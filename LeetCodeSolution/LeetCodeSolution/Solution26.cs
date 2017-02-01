using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }

            int InsertIndex = 1;
            int current = nums[0];

            for(int i = 1; i < nums.Length;i++)
            {
                if(current != nums[i])
                {
                    nums[InsertIndex] = nums[i];
                    current = nums[i];
                    InsertIndex++;
                    continue;
                }
            }

            return InsertIndex;
        }
    }
}
