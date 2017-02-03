using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution300
    {
        //https://en.wikipedia.org/wiki/Longest_increasing_subsequence
        public int LengthOfLIS(int[] nums)
        {
            if(nums.Length == 0)
            { return 0; }
            List<int> selection = new List<int>();
            selection.Add(nums[0]);
            for(int i = 1; i < nums.Length; i++)
            {
                int v = nums[i];

                if(selection.Last() < v)
                {
                    selection.Add(v);
                    continue;
                }

                for(int j = 0; j < selection.Count; j++)
                {
                    if(selection[j] >= v)
                    {
                        selection[j] = v;
                        break;
                    }
                }
            }

            return selection.Count();
        }
    }
}
