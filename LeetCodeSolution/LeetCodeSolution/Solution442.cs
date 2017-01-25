using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution442
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    runSort(ref nums, ref result, i);
                }
            }

            return result;
        }

        private void runSort(ref int[] nums, ref List<int> result, int index)
        {
            int value = nums[index];
            nums[index] = 0;
            insertValue(ref nums, ref result, value);

            return;
        }

        private void insertValue(ref int[] nums, ref List<int> result, int value)
        {
            int index = value - 1;
            if(index < 0)
            {
                return;
            }

            if (nums[index] == value)
            {
                result.Add(value);
                return;
            }

            int newValue = nums[index];
            nums[index] = value;

            insertValue(ref nums, ref result, newValue);
        }
    }
}
