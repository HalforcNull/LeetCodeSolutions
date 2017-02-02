using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution28
    {
        public int CSharpLazyStrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }

        public int StrStr(string haystack, string needle)
        {
            if(haystack.Length < needle.Length)
            {
                return -1;
            }

            for(int i = 0; i < haystack.Length-needle.Length + 1; i++)
            {
                if(isSame(haystack.Substring(i,needle.Length), needle))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool isSame(string s1, string s2)
        {
            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i] != s2[i])
                { return false; }
            }
            return true;
        }
    }
}
