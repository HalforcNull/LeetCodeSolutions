using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution13
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            int max = 0;

            s = s.Replace(" ", "").ToUpper();

            for(int i = s.Length-1; i >=0; i-- )
            {
                int current = RomanCharToInt(s[i]);
                if(current == 0)
                { return 0; }

                if(max > current)
                {
                    result -= current;
                    continue;
                }
                else
                {
                    max = current;
                    result += current;
                    continue;
                }
            }
            return result;
        }

        public int RomanCharToInt(char ch)
        {
            switch(ch)
            {
                case 'M':
                    return 1000;
                case 'D':
                    return 500;
                case 'C':
                    return 100;
                case 'L':
                    return 50;
                case 'X':
                    return 10;
                case 'V':
                    return 5;
                case 'I':
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
