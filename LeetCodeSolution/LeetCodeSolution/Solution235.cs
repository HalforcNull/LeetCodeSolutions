using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution235
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode temp = null;
            if(p.val > q.val)
            {
                temp = q;
                q = p;
                p = temp;
            }

            if(p.val < root.val && q.val > root.val
                || p.val == root.val
                || q.val == root.val
                )
            {
                return root;
            }

            if(p.val < root.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            else
            {
                return LowestCommonAncestor(root.right, p, q);
            }
        }


    }
}
