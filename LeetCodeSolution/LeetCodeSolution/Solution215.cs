using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution215
    {
        public int CSharpLazySolution(int[] nums, int k)
        {
            List<int> t = nums.ToList();
            t.Sort();
            return t[t.Count - k];
        }

        /// <summary>
        /// Quick select option
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int FindKthLargest(int[] nums, int k)
        {
            List<int> LowerRow = new List<int>();
            List<int> HigerRow = new List<int>();

            Random r = new Random();
            int pointer = r.Next(nums.Length);
            int pivot = nums[pointer];
            
            foreach(int num in nums)
            {
                if(num<pivot)
                {
                    LowerRow.Add(num);
                    continue;
                }
                 
                if(num>pivot)
                {
                    HigerRow.Add(num);
                    continue;
                }
            }

            if(k<= HigerRow.Count)
            {
                return FindKthLargest(HigerRow.ToArray(), k);
            }

            if(k>nums.Length - LowerRow.Count)
            {
                return FindKthLargest(LowerRow.ToArray(), k - nums.Length + LowerRow.Count);
            }

            return pivot;
        }


    }
}