using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution121Tests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            Solution121 s = new Solution121();
            int[] input = { 2, 1, 2, 1, 0, 1, 2 };
            s.MaxProfit(input);
        }
    }
}