using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution75
    {
        public void SortColors(int[] nums)
        {
            int countOfRed = 0;
            int countOfWhite = 0;
            int countOfBlue = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                { countOfRed++; continue; }

                if(nums[i] == 1)
                { countOfWhite++; continue; }

                countOfBlue++;
            }


            for(int i = 0; i < nums.Length;i++)
            {
                if(i<countOfRed)
                {
                    nums[i] = 0;
                    continue;
                }

                if (i < countOfRed+ countOfWhite)
                {
                    nums[i] = 1;
                    continue;
                }

                nums[i] = 2;
            }

            /* works in Visual Studio, error in Leetcode
            nums = Enumerable.Repeat(0, countOfRed).Concat(
                        Enumerable.Repeat(1, countOfWhite).Concat(
                            Enumerable.Repeat(2, countOfBlue)
                            )
                        ).ToArray();
            */
            
            return;
        }
    }
}
