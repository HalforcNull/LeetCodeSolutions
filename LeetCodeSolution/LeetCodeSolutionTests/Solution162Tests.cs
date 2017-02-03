using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution162Tests
    {
        [TestMethod()]
        public void FindPeakElementTest()
        {
            int[] nums = { 2,1,2 };
            Solution162 s = new Solution162();
            s.FindPeakElement(nums);

        }
    }
}