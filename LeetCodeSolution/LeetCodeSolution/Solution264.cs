using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution264
    {
        public int NthUglyNumber(int n)
        {
            int current = 0;
            while (n != 0)
            {
                current++;

                if (isUglyNumber(current))
                {
                    n--;
                }
            }

            return current;
        }

        private bool isUglyNumber(int n)
        {
            while (n % 2 == 0)
            {
                n = n / 2;
            }

            while (n % 3 == 0)
            {
                n = n / 3;
            }

            while (n % 5 == 0)
            {
                n = n / 5;
            }

            return n == 1;

        }
    }
}
