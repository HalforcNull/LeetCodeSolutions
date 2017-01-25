using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution241Tests
    {
        [TestMethod()]
        public void DiffWaysToComputeTest()
        {

        }

        [TestMethod()]
        public void DiffWaysToComputeTest1()
        {
            Solution241 s = new Solution241();
            string input = "2-1-1";
            int[] expectedOutput = { 0, 2 };

            int[] result = s.DiffWaysToCompute(input).ToArray();

            Assert.AreEqual(expectedOutput.Length, result.Length);

            for(int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expectedOutput[i], result[i]);
            }

        }
    }
}