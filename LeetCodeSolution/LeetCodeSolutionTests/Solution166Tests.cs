using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution166Tests
    {
        [TestMethod()]
        public void FractionToDecimalTest()
        {
            Solution166 s
                 = new Solution166();
            s.FractionToDecimal(7, -12);
        }
    }
}