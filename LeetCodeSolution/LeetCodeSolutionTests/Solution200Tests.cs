using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution200Tests
    {
        [TestMethod()]
        public void NumIslandsTest()
        {
            Solution200 s = new Solution200();
            char[,] grid = new char[,]
            {
                {'1','1','0','0','0' },
                {'1','1','0','0','0' },
                {'0','0','1','0','0' },
                {'0','0','0','1','1' }
            };
            int r =   s.NumIslands(grid);

            r = r + 1;
        }
    }
}