using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution88
    {
        /// <summary>
        /// C# could do it simply using List and the related functions. 
        /// However, is won't be the thing people want to test. 
        /// 
        /// Boundary is a trap
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if(n == 0)
            {
                return;
            }

            if(m == 0)
            {
                for(int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
            }

            int[] temp = new int[m];
            for(int i = 0; i < m; i ++)
            {
                temp[i] = nums1[i];
            }

            int tempIndex = 0;
            int nums2Index = 0;
            for(int i = 0; i < m+n;i++)
            {
                if(tempIndex == m)
                {
                    nums1[i] = nums2[nums2Index];
                    nums2Index++;
                    continue;
                }

                if(nums2Index == n)
                {
                    nums1[i] = temp[tempIndex];
                    tempIndex++;
                    continue;
                }

                if(temp[tempIndex] < nums2[nums2Index])
                {
                    nums1[i] = temp[tempIndex];
                    tempIndex++;
                }
                else
                {
                    nums1[i] = nums2[nums2Index];
                    nums2Index++;
                }
            }
            return;
        }

    }
}
