using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution8
    {
        public int MyAtoi(string str)
        {
            int result;
            int symbol;
            str = str.Trim();
            if (String.IsNullOrWhiteSpace(str))
            {
                return 0;
            }



            if (str[0] == '-')
            {
                result = 0;
                symbol = -1;
            }
            else if (str[0] == '+')
            {
                result = 0;
                symbol = 1;
            }
            else if ((int)str[0] <= 57 && (int)str[0] >= 48)
            {

                result = (int)str[0] - 48;
                symbol = 1;
            }
            else
            { return 0; }


            for (int i = 1; i < str.Length; i++)
            {
                if ((int)str[i] > 57 || (int)str[i] < 48)
                {
                    //contains any invalid digit

                    return result * symbol;
                }

                if (result > int.MaxValue / 10
                    || (symbol == 1 && result == int.MaxValue / 10 && (str[i] - 48 > 7))
                    || (symbol == -1 && result == int.MaxValue / 10 && (str[i] - 48 > 8))
                    )
                {
                    if(symbol == 1)
                    {
                        return int.MaxValue;
                    }
                    else
                    {
                        return int.MinValue;
                    }
                }
                result = result * 10 + (str[i] - 48);
            }
            return result * symbol;
        }
    }
}
