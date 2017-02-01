using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{   
    public class Solution387
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> chCount = new Dictionary<char, int>();
            Dictionary<char, int> chIndex = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if(!chCount.ContainsKey(c) )
                {
                    chCount.Add(c, 1);
                    chIndex.Add(c, i);
                }
                else
                {
                    chCount[c]++;
                }
            }

            if (chCount.Count == 0)
            { return -1; }

            int index = -1;
            foreach(KeyValuePair<char,int> c in chCount)
            {
                if(c.Value != 1)
                { continue; }

                if(index < 0 || chIndex[c.Key] < index)
                { index = chIndex[c.Key]; }
            }

            return index;
        }
    }
}
