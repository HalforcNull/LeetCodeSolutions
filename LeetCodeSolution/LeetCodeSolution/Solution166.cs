using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution166
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            List<Int64> remains = new List<Int64>();
            List<Int64> results = new List<Int64>();

            if(denominator == 0)
            { return string.Empty; }

            Int64 num64 = Convert.ToInt64(numerator);
            Int64 denom64 = Convert.ToInt64(denominator);

            Int64 remain = num64 % denom64;
            Int64 beforeDecimal = num64 / denom64;

            if (remain == 0)
            {
                return beforeDecimal.ToString();
            }

            string sign = "";

            if(numerator < 0 && denominator >0 ||
                numerator > 0 && denominator < 0)
            {
                sign = "-";
            }

            return sign + Math.Abs(beforeDecimal) + "." + getCurrentRemainResult(remain, denom64, remains, results);
        }

        private string getCurrentRemainResult(Int64 remain, Int64 denominator, List<Int64> remains, List<Int64> results)
        {
            if(remain == 0)
            {
                return processNonRepeatingResult(results);
            }

            if(remains.Contains(remain))
            {
                return processRepeatingResult(remain, remains, results);
            }

            Int64 newRemain = remain*10 % denominator;
            Int64 result = remain*10 / denominator;


            remains.Add(remain);
            results.Add( Math.Abs(result)) ;

            return getCurrentRemainResult(newRemain, denominator, remains, results);
        }

        private string processRepeatingResult(Int64 remain, List<Int64> remains, List<Int64> results)
        {
            int indexOfFirstRemain = remains.FindIndex(t=>t == remain);
            string output = "";
            for( int i = 0; i < indexOfFirstRemain; i++)
            {
                output += results[i];
            }

            output += "(";
            for(int i = indexOfFirstRemain; i < remains.Count;i++)
            {
                output += results[i];
            }
            output += ")";

            return output;
        }

        private string processNonRepeatingResult(List<Int64> results)
        {
            return string.Concat( results.ConvertAll<string>(t =>  t.ToString()) );
        }
    }
}
