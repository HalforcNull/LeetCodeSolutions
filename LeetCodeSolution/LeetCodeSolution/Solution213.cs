using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution213
    {
        public int Rob(int[] nums)
        {
            if(nums.Length == 0)
            {   return 0;     }

            if(nums.Length == 1)
            { return nums[0]; }

            int RobFirstRobPre = nums[0];
            int NotRobFirstRobPre = 0;
            int RobFirstNotRobPre = 0;
            int NotRobFirstNotRobPre = 0;

            for(int i = 1; i < nums.Length - 1; i++)
            {
                //header and end need process seperately
                int RobFirstRobCurrent = RobFirstNotRobPre + nums[i];
                int NotRobFirstRobCurrent = NotRobFirstNotRobPre + nums[i];
                int RobFirstNotRobCurrent = Math.Max( RobFirstRobPre, RobFirstNotRobPre );
                int NotRobFirstNotRobCurrent = Math.Max( NotRobFirstRobPre, NotRobFirstNotRobPre);

                RobFirstRobPre = RobFirstRobCurrent;
                NotRobFirstRobPre = NotRobFirstRobCurrent;
                RobFirstNotRobPre = RobFirstNotRobCurrent;
                NotRobFirstNotRobPre = NotRobFirstNotRobCurrent;
            }

            NotRobFirstNotRobPre += nums[nums.Length - 1];

            return Math.Max(RobFirstRobPre,
                        Math.Max(NotRobFirstRobPre,
                            Math.Max(RobFirstNotRobPre, NotRobFirstNotRobPre)));
        }
    }
}
