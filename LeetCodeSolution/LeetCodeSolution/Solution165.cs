using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution165
    {
        public int CompareVersion(string version1, string version2)
        {
            string[] v1s = version1.Split(".".ToArray());
            string[] v2s = version2.Split(".".ToArray());

            int i = 0;
            while(i<v1s.Length || i<v2s.Length)
            {
                string l,r;

                if(i >= v1s.Length)
                { l = ""; }
                else
                { l = v1s[i]; }

                if (i >= v2s.Length)
                { r = ""; }
                else
                { r = v2s[i]; }


                int result = PartialCopare(l, r);
                if(result == 0)
                { i++; continue; }

                return result;
            }

            return 0;
        }



        public int PartialCopare(string s1, string s2)
        {
            if(s1.Length < s2.Length)
            {
                s1 = ( new string(Enumerable.Repeat('0', s2.Length - s1.Length).ToArray()) ) + s1;
            }
            else
            {
                s2 = (new string(Enumerable.Repeat('0', s1.Length - s2.Length).ToArray())) + s2;
            }

            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i] > s2[i])
                {
                    return 1;
                }

                if(s1[i] < s2[i])
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
