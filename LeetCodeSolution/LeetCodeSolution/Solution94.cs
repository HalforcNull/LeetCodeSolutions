using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution94
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            if(root == null)
            {
                return new List<int>();
            }

            IList<int> leftResult = InorderTraversal(root.left);
            IList<int> rightResult = InorderTraversal(root.right);

            leftResult.Add(root.val);
            foreach (int i in rightResult)
            { leftResult.Add(i); }

            return leftResult;
        }

    }
}
