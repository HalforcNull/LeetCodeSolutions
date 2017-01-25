using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution216Tests
    {
        [TestMethod()]
        public void CombinationSum3Test()
        {
            Solution216 s = new Solution216();
            int k = 3;
            int n = 7;

            int[] r1 = { 1, 2, 4 };
            IList<IList<int>> result = s.CombinationSum3(k,n);

            Assert.AreEqual(1, result.Count);
            foreach(IList<int> r in result)
            {
                foreach(int r1N in r1)
                {
                    Assert.IsTrue(r.Contains(r1N));
                    r.Remove(r1N);
                }
            }

        }


        [TestMethod()]
        public void CombinationSum3Test1()
        {
            Solution216 s = new Solution216();
            int k = 2;
            int n = 6;

            int[] r1 = { 1,5 };
            int[] r2 = { 2, 4 };
            List<int[]> rs = new List<int[]>();
            rs.Add(r1);
            rs.Add(r2);

            IList<IList<int>> result = s.CombinationSum3(k, n);

            Assert.AreEqual(rs.Count, result.Count);

        }
    }
}