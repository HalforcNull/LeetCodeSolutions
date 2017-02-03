using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution79Tests
    {
        [TestMethod()]
        public void ExistTest()
        {
            Solution79 s = new Solution79();
            char[,] board =
            {
                {'A','B','C','E' },
                {'S','F','C','S' },
                {'A', 'D','E','E' }
            };

            s.Exist(board, "ABCCED");
        }
    }
}