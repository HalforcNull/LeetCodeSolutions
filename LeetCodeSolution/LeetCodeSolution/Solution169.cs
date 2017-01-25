using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution169
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();

            double half = Math.Ceiling(((double)nums.Length) / 2);
            for(int i = 0; i < nums.Length; i++)
            {
                int value = nums[i];
                if(counter.ContainsKey(value))
                {
                    counter[value]++;
                }
                else
                { counter.Add(value, 1); }

                if (counter[value] >= half)
                { return value; }
            }

            return 0;
        }
    }
}