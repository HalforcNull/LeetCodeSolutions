using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution55
    {
        public bool CanJump(int[] nums)
        {
            int jumpCap = 0;
            for(int i = 0; i < nums.Length - 1; i++)
            {
                jumpCap = Math.Max(jumpCap, nums[i]);
                if(jumpCap == 0)
                { return false; }

                jumpCap--;
            }

            return true;
        }



        /* mis understand the question
        public bool CanJump(int[] nums)
        {
            bool[] checkPoint = new bool[nums.Length];

            return Jump(nums, ref checkPoint, 0);
            
        }

        private bool Jump(int[] nums, ref bool[] checkPoint, int v)
        {
            int forward = v + nums[v];
            int backward = v - nums[v];
            checkPoint[v] = true;

            return forward < nums.Length && !checkPoint[forward] && Jump(nums, ref checkPoint, forward)  //if we can jump forward, test whether it is a solution
                || backward >= 0 && !checkPoint[backward] && Jump(nums, ref checkPoint, backward);       //if we can jump backward, test whether it is a solution
                                                                                                         //only need one of the two directions provide a solution, 
        }
        */
    }
}
