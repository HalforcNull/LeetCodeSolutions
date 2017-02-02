using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution53
    {
        public int MaxSubArray(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }

            int knownBestDone = nums[0];
            int PrenodeSelectedSum = nums[0];

            for(int i = 1; i<nums.Length;i++)
            {
                int v = nums[i];

                if(knownBestDone < PrenodeSelectedSum)
                {
                    // Based on 'Not picking current num' 

                    // int SelectNoSelect = PrenodeSelectedSum
                    // So this cirtria equal to: the building result( the sum of all continuely selected num ) is better than current best
                    // If we not select current num, the building result beat current best one.
                    knownBestDone = PrenodeSelectedSum;
                }
                
                if(PrenodeSelectedSum > 0)
                {
                    // Based on 'Picking current num'

                    // If PreSelected is greater than 0; also add them into the range
                    PrenodeSelectedSum = PrenodeSelectedSum + v;
                }
                else
                {
                    // Otherwise, a new start from current node is better
                    PrenodeSelectedSum = v;
                }
            }

            return Math.Max(knownBestDone, PrenodeSelectedSum);
        }
    }
}
