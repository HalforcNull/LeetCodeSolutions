using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution213Tests
    {
        [TestMethod()]
        public void RobTest()
        {
            Solution213 s = new Solution213();
            int[] intput = { 1, 3, 1, 3, 100 };
            s.Rob(intput);
        }
    }
}