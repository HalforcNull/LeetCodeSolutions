using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution189
    {
        public void Rotate(int[] nums, int k)
        {
            int length = nums.Length;
            if (length == 0 || k % length == 0)
            {
                return;
            }

            int startI = 0;
            int currentI = 0;
            int currentV = nums[0];


            for (int i = 0; i < nums.Length; i++)
            {
                int nextI = (currentI + k) % length;
                int nextV = nums[nextI];
                nums[nextI] = currentV;


                currentI = nextI;
                currentV = nextV;
                if (currentI == startI)
                {
                    startI++;
                    currentI = startI % length;
                    currentV = nums[currentI];
                }
            }


            return;
        }
    }
}
