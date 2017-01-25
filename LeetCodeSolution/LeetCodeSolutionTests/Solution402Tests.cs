using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution402Tests
    {
        [TestMethod()]
        public void RemoveKdigitsTest()
        {
            Solution402 s = new Solution402();
            string result = s.RemoveKdigits("112", 1);

            Assert.AreEqual("11", result);

            return;
        }

        [TestMethod()]
        public void RemoveKdigitsTest2()
        {
            Solution402 s = new Solution402();
            string result = s.RemoveKdigits("10200", 1);

            Assert.AreEqual("200", result);

            return;
        }
    }
}