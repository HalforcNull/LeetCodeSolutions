using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution171
    {
        public int TitleToNumber(string s)
        {
            int output = 0;
            foreach(char c in s)
            {
                output = output * 26 + (int)c -(int)'A' + 1;
            }

            return output;
        }
    }
}
