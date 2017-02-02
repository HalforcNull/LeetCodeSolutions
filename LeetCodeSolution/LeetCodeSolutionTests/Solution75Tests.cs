using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution75Tests
    {
        [TestMethod()]
        public void SortColorsTest()
        {
            Solution75 s = new Solution75();
            int[] nums = { 1, 0 };
            s.SortColors(nums);
        }
    }
}