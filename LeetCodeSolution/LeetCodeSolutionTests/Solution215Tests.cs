using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution215Tests
    {
        [TestMethod()]
        public void FindKthLargestTest()
        {
            Solution215 s = new Solution215();
            int[] nums = { 2,1 };
            s.FindKthLargest(nums, 2);
        }
    }
}