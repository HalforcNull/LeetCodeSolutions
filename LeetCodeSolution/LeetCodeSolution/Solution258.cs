using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution258
    {
        public int AddDigits(int num)
        {
            int current = num;
            while(current > 9)
            {
                int temp = current;
                int result = 0;
                while(temp > 0)
                {
                    result += temp % 10;
                    temp = temp / 10;
                }
                current = result;
            }
            return current;
        }
    }
}
