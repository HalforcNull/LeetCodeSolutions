using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution168
    {
        public string ConvertToTitle(int n)
        {
            int current = n;
            string result = "";
            do
            {
                result = ConvertSignleBit((current - 1) % 26) + result;
                current = (current - 1) / 26;
            } while (current > 0);

            return result;
        }

        /// <summary>
        /// zero based convert
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public char ConvertSignleBit(int n)
        {
            return (char)(n + 65);
        }
    }
}
