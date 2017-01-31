using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution236
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            int dummyCount;
            return SeekingAndCountNodes(root, p, q, out dummyCount);
        }

        public TreeNode SeekingAndCountNodes(TreeNode root, TreeNode p, TreeNode q, out int pqCount)
        {   
            int leftPQCount = 0, rightPQCount = 0;
            TreeNode leftResult = null, rightResult = null;

            if(root.left != null)
            {
                leftResult = SeekingAndCountNodes(root, p, q, out leftPQCount);
            }

            if(root.right != null)
            {
                rightResult = SeekingAndCountNodes(root, p, q, out rightPQCount);
            }

            bool rootIsOneOfPQ = root.val == p.val || root.val == q.val;

            if(leftPQCount == 1 && rightPQCount == 1 ||
               rootIsOneOfPQ && (leftPQCount == 1 || rightPQCount == 1) )
            {
                pqCount = 2;
                return root;
            } 

            if(leftPQCount == 2)
            {
                pqCount = 2;
                return leftResult;
            }

            if(rightPQCount == 2)
            {
                pqCount = 2;
                return rightResult;
            }

            pqCount = leftPQCount + rightPQCount;
            return null;
        }
    }
}
