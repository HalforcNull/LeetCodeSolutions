using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution.Tests
{
    [TestClass()]
    public class Solution41Tests
    {
        [TestMethod()]
        public void FirstMissingPositiveTest()
        {
            Solution41 s = new Solution41();

            int[] input = { 1, 2, 3, 4 };
            int expectedOutput = 5;


            int output = s.FirstMissingPositive(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest2()
        {
            Solution41 s = new Solution41();

            int[] input = { 1, 1, 1,1 };
            int expectedOutput = 2;


            int output = s.FirstMissingPositive(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest3()
        {
            Solution41 s = new Solution41();

            int[] input = { 1, 1, 1, 6 };
            int expectedOutput = 2;


            int output = s.FirstMissingPositive(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest4()
        {
            Solution41 s = new Solution41();

            int[] input = { 0,1,2 };
            int expectedOutput = 3;


            int output = s.FirstMissingPositive(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest5()
        {
            Solution41 s = new Solution41();

            int[] input = { 0};
            int expectedOutput = 1;


            int output = s.FirstMissingPositive(input);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}