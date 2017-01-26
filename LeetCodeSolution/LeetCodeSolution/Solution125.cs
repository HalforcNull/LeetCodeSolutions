using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution125
    {
        public bool IsPalindrome(string s)
        {
            List<char> cList = s.ToLower().ToList().FindAll(c => Char.IsLetter(c)||Char.IsDigit(c));
            if(cList.Count < 2)
            {
                return true;
            }

            int up = cList.Count - 1;

            for (int i = 0; i < cList.Count / 2; i++)
            {
                if(cList[i] != cList[up-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
