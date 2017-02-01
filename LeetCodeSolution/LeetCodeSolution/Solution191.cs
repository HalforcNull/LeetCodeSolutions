using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution191
    {
        public int HammingWeight(uint n)
        {
            uint remain = n;
            int result = 0;
            while(remain != 0)
            {
                if(remain % 2 == 1)
                { result++; }
                remain = remain / 2;
            }

            return result;
        }
    }
}
