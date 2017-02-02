using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution151
    {
        public string CSharpLazyWay(string s)
        {
            return string.Join(" ", s.Split(" ".ToArray()).ToArray().Reverse());
        }

        /// <summary>
        /// this solution is based on 'For C programmers: Try to solve it in-place in O(1) space.'
        /// We have to use an char[] since string[i] is read only
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWords(string s)
        {
            s = s.Trim();
            while(s.Contains("  "))
            { s = s.Replace("  ", " "); }
            
            if(s.Length == 0)
            {
                return s;
            }

            char[] CTypeString = s.ToArray();
            int begin = 0;
            int end = -1;

            for( int i = 0; i < CTypeString.Length; i++)
            {
                // reverse each word, except last one
                if (CTypeString[i] != ' ')
                {
                    continue;
                }

                end = i - 1;
                ReverseWord(CTypeString, begin, end);
                begin = i + 1;
                end = -1;
            }

            //todo: revers last word
            end = CTypeString.Length - 1;
            ReverseWord(CTypeString, begin, end);
            

            return string.Join("", CTypeString.Reverse());
        }

        private static void ReverseWord(char[] CTypeString, int begin, int end)
        {
            int wordLength = end - begin + 1;
            for (int j = 0; j < wordLength / 2; j++)
            {
                int first = j + begin;
                int second = end - j;
                char c = CTypeString[first];
                CTypeString[first] = CTypeString[second];
                CTypeString[second] = c;
            }
        }
    }
}
