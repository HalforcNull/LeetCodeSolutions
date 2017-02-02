using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution151Tests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            Solution151 s = new Solution151();
            s.ReverseWords("Hello world!");
        }
    }
}