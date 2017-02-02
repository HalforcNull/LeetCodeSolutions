using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution101
    {
        public bool IsSymmetric(TreeNode root)
        {
            List<TreeNode> TreeNodes = new List<TreeNode>();
            if (root == null)
            {
                return true;
            }

            if (root.left == null && root.right == null)
            {
                return true;
            }

            return checkNodes(root.left, root.right);
        }

        public bool checkNodes(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            return left.val == right.val && checkNodes(left.left, right.right) && checkNodes(left.right, right.left);
        }
    }
}
