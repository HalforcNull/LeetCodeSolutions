using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution402
    {
        public string RemoveKdigits(string num, int k)
        {
            if(k == 0)
            { return num; }

            if(k >= num.Length)
            { return "0"; }

            int zeroCount;
            string newNum = processHeadZeros(num, k, out zeroCount);
            int cutCost = num.Length - newNum.Length - zeroCount;

            return removeHeadZeros(cutDigit(newNum, k- cutCost));
            
        }

        private string cutDigit(string num, int k)
        {
            int start = findHead(num, k);
            if(start <0)
            {
                return "0";
            }

            char newHead = num[start];
            string newStr = num.Substring(start + 1);

            return newHead + cutTail(newStr, k - start);
        }

        private string processHeadZeros(string num, int k, out int zeroCount)
        {
            int privateK = k;
            zeroCount = 0;
            return subFindHeadZeros(num, ref privateK, ref zeroCount);
        }

        private string subFindHeadZeros(string num, ref int k, ref int zeroCount)
        {
            for( int i = 0; i < k; i++)
            {
                if(num[i] == '0')
                {
                    k -= i;
                    zeroCount++;
                    return subFindHeadZeros(num.Substring(i + 1), ref k, ref zeroCount);
                }
            }

            return num;
        }
        private int findHead(string num, int k)
        {
            if (k <= 0)
            {
                return -1;
            }

            string handleStr = num.Substring(0, k+1);

            int end = 0;

            for(int i = 0; i < 10;i++)
            {
                end = handleStr.IndexOf((char)(i + 48));
                if (end >= 0)
                {
                    break;
                }

            }

            if(end < 0)
            { return -1; }
            return end;
        }

        private string cutTail(string num, int k)
        {
            if( k <= 0)
            {
                return num;
            }

            int index = num.Length - 1;

            for( int i = 0; i < num.Length - 1; i++)
            {
                if( (int)num[i] > (int)num[i+1] )
                {
                    index = i;
                    break;
                }
            }

            string newStr = num.Substring(0, index);
            if( index < num.Length - 1 )
            { newStr += num.Substring(index + 1); }
              
            k--;

            return cutTail(newStr, k);
        }

        private string removeHeadZeros(string current)
        {
            int index = current.ToList().FindIndex(d => d != '0');
            if(index<0)
            { return "0"; }
            else
            { return current.Substring(index); }
            
        }
    }
}
