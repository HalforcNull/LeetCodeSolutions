using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution452Tests
    {
        [TestMethod()]
        public void FindMinArrowShotsTest()
        {
            Solution452 s = new Solution452();
            int[,] input = { { 10, 16 }, { 2, 8 }, { 1, 6 }, { 7, 12 } };
            s.FindMinArrowShots(input);
        }
    }
}