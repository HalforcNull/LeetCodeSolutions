using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    /*
    Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

    For example,
    Given nums = [0, 1, 3] return 2.

    Note:
    Your algorithm should run in linear runtime complexity. Could you implement it using only constant extra space complexity?
    */

    /*
     actual length = nums.Length - 1;
     actual sum = nums.sum - missing num;
     missing = (n-1)*n/2-nums.sum; where n = nums.Length + 1
     */
 
    public class Solution268
    {
        public int MissingNumber(int[] nums)
        {
            int n = nums.Length + 1;
            return n * n / 2 - nums.Sum();
        }
    }
}
