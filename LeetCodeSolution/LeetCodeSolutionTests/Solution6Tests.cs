using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution6Tests
    {
        [TestMethod()]
        public void ConvertTest()
        {
            Solution6 s = new Solution6();
            string inputStr = "PAYPALISHIRING";
            int rowNum = 3;

            string expectedOutput = "PAHNAPLSIIGYIR";

            string result = s.Convert(inputStr, rowNum);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void ConvertTest2()
        {
            Solution6 s = new Solution6();
            string inputStr = "ABCDEFGH";
            int rowNum = 4;

            string expectedOutput = "AGBFHCED";

            string result = s.Convert(inputStr, rowNum);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void ConvertTest3()
        {
            Solution6 s = new Solution6();
            string inputStr = "ABCD";
            int rowNum = 3;

            string expectedOutput = "ABDC";

            string result = s.Convert(inputStr, rowNum);

            Assert.AreEqual(expectedOutput, result);
        }
    }
}