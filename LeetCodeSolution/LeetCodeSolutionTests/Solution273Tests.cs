using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution273Tests
    {
        [TestMethod()]
        public void NumberToWordsTest()
        {
            Solution273 s = new Solution273();
            s.NumberToWords(103);
        }
    }
}