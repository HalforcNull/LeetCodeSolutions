using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution106Tests
    {
        [TestMethod()]
        public void BuildTreeTest()
        {
            Solution106 s = new Solution106();
            int[] inO = { 1, 2, 3, 4 };
            int[] pO = { 3, 4, 2, 1 };
            s.BuildTree(inO, pO);
        }
    }
}