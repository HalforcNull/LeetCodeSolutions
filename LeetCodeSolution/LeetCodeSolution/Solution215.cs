using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution215
    {
        public int FindKthLargest(int[] nums, int k)
        {
            List<int> t = nums.ToList();
            t.Sort();
            return t[t.Count-k];
        }
    }
}