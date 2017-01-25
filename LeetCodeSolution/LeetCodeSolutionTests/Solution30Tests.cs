using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution30Tests
    {
        [TestMethod()]
        public void FindSubstringTest()
        {
            Solution30 s = new Solution30();
            string inputS = "barfoothefoobarman";
            string[] words = { "foo", "bar" };
            List<int> result = s.FindSubstring(inputS, words).ToList();


            return;
        }

        [TestMethod()]
        public void FindSubstringTest2()
        {
            Solution30 s = new Solution30();
            string inputS = "a";
            string[] words = { "a", "a" };
            List<int> result = s.FindSubstring(inputS, words).ToList();


            return;
        }


        [TestMethod()]
        public void FindSubstringTest3()
        {
            Solution30 s = new Solution30();
            string inputS = "wordgoodgoodgoodbestword";
            string[] words = { "word", "good", "best", "good" };
            List<int> result = s.FindSubstring(inputS, words).ToList();


            return;
        }
    }
}