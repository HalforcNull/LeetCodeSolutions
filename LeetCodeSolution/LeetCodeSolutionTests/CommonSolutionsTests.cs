using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class CommonSolutionsTests
    {
        [TestMethod()]
        public void PermuteUniqueTest()
        {
            CommonSolutions s = new CommonSolutions();
            int[] input = { 1, 1, 2 };
            s.PermuteUnique(input);
        }
    }
}