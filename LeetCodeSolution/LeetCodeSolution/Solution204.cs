using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution204
    {
        public int CountPrimes(int n)
        {
            if(n < 3)
            {
                return 0;
            }

            bool[] isPrime = Enumerable.Repeat(true, n).ToArray();

            
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * 2; j < n; j = j + i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i]) count++;
            }
            return count;
        }
    }
}
