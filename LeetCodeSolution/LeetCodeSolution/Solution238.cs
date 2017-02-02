using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    
    public class Solution238
    {
        /// <summary>
        /// constant space solution based on follow up:
        /// 
        /// 
        /// Could you solve it with constant space complexity? 
        /// (Note: The output array does not count as extra space for the purpose of space complexity analysis.)
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            int length = nums.Length;
            int[] rightHandProduct = new int[length];

            rightHandProduct[length - 1] = 1;
            for( int i = length - 2; i >= 0; i--)
            {
                rightHandProduct[i] = rightHandProduct[i + 1] * nums[i + 1];
            }

            int currentLeftProduct = 1;
            for( int i = 0; i < length; i ++)
            {
                rightHandProduct[i] = rightHandProduct[i] * currentLeftProduct;
                currentLeftProduct = currentLeftProduct * nums[i];
            }

            return rightHandProduct;
        }
    }
}
