using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution198
    {
        public int Rob(int[] nums)
        {
            int chooseMax = 0;
            int notChooseMax = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                int chooseThenNot = chooseMax;
                int notchooseThenNot = notChooseMax;
                int notchooseThenChoose = notChooseMax + nums[i];
                if(chooseThenNot > notchooseThenNot)
                {
                    notChooseMax = chooseThenNot;
                }
                chooseMax = notchooseThenChoose;
            }

            if(chooseMax > notChooseMax)
            {
                return chooseMax;
            }
            else
            {
                return notChooseMax;
            }
        }
    }
}
