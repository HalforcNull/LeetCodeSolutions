using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution168Tests
    {
        [TestMethod()]
        public void ConvertToTitleTest()
        {
            Solution168 s = new Solution168();
            s.ConvertToTitle(27);
        }
    }
}