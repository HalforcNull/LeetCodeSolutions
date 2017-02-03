using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution5
    {
        public string LongestPalindrome(string s)
        {
            string currentMax = "";

            for(int i = 0; i <s.Length; i++)
            {
                int oddHalfLength = maxSame(s, i - 1, i + 1);
                int evenHalfLength = maxSame(s, i, i + 1);

                if(oddHalfLength * 2 + 1 > currentMax.Length)
                {
                    currentMax = s.Substring(i - oddHalfLength, oddHalfLength) + s[i] + s.Substring(i + 1, oddHalfLength);
                }

                if(evenHalfLength * 2 > currentMax.Length)
                {
                    currentMax = s.Substring(i - evenHalfLength + 1, evenHalfLength * 2);
                }
            }

            return currentMax;

        }


        public int maxSame(string s, int l, int r)
        {
            int length = 0;
            while(l >= 0 && r < s.Length)
            {
                if(s[l] != s[r])
                {
                    break;
                }

                length++;
                l--;
                r++;
                continue;
            }
            return length;
        }
    }

}
