using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution436Tests
    {
        [TestMethod()]
        public void FindRightIntervalTest()
        {
            Solution436 s = new Solution436();

            Interval input1 = new Interval(1,2);

            Interval[] input = { input1 };

            int[] result = s.FindRightInterval(input);

            int[] expected = { -1 };

            Assert.AreEqual(expected.Length, result.Length);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void FindRightIntervalTest1()
        {
            Solution436 s = new Solution436();
            
            Interval input1 = new Interval(3, 4);
            Interval input2 = new Interval(2, 3);
            Interval input3 = new Interval(1, 2);

            Interval[] input = { input1, input2, input3 };

            int[] result = s.FindRightInterval(input);

            int[] expected = { -1,0,1 };

            Assert.AreEqual(expected.Length, result.Length);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}