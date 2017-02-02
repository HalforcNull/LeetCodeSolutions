using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution33Tests
    {
        [TestMethod()]
        public void SearchTest()
        {
            int[] input = { 8, 1, 2, 3, 4, 5, 6, 7 };
            Solution33 s = new Solution33();

            s.Search(input, 6);
        }
    }
}