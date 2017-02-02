using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution98
    {
        public bool IsValidBST(TreeNode root)
        {
            if(root == null)
            {
                return true;
            }

            return IsValidBSTSub(root, null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="min"> min, if is left son; root.val if it is right son</param>
        /// <param name="max"> root.val, if is left son; max, if it is right son</param>
        /// <returns></returns>
        public bool IsValidBSTSub(TreeNode root, int? min, int? max)
        {

            if (root == null)
            {
                return true;
            }

            if (min != null && (min >= root.val) )
            {
                return false;
            }

            if( max!=null && (max <= root.val))
            {
                return false;
            }

            bool currentIsBST = true;

            bool leftIsBST = true;
            if(root.left != null)
            {
                leftIsBST = IsValidBSTSub(root.left, min, root.val);
                currentIsBST = currentIsBST && root.val > root.left.val;
            }

            bool rightIsBST = true;
            if(root.right != null)
            {
                rightIsBST = IsValidBSTSub(root.right, root.val, max);
                currentIsBST = currentIsBST && root.val < root.right.val;
            }

            
            return leftIsBST && rightIsBST && currentIsBST;

        }
    }
}
