using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            CommonSolutions s = new CommonSolutions();
            return s.KSum(nums, 0, 3);
        }

    }
}
