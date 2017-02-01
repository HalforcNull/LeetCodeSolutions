using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution189Tests
    {
        [TestMethod()]
        public void RotateTest()
        {
            Solution189 s = new Solution189();
            int[] input = { 1, 2 };//, 3, 4, 5, 6 };
            s.Rotate(input, 1);
        }
    }
}