using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution91Tests
    {
        [TestMethod()]
        public void NumDecodingsTest()
        {
            Solution91 s = new Solution91();
            int i =  s.NumDecodings("20");

            int j = i;
        }
    }
}