using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution169Tests
    {
        [TestMethod()]
        public void MajorityElementTest()
        {
            Solution169 s = new Solution169();
            int[] input = { 1 };
            int result = s.MajorityElement(input);

            Assert.AreEqual(1, result);
        }
    }
}