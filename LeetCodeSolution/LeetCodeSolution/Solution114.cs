using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution114
    {
        public void Flatten(TreeNode root)
        {
            if(root ==null)
            { return ; }
            FlattenSub(root);
        }

        public TreeNode FlattenSub(TreeNode root)
        {
            if(root.left == null && root.right ==null)
            {
                return root;
            }

            TreeNode oLeft = root.left;
            TreeNode oRight = root.right;

            root.left = null;
            if(oLeft == null)
            {
                return FlattenSub(oRight);
            }

            if(oRight == null)
            {
                root.right = oLeft;
                return FlattenSub(oLeft);
            }

            root.right = oLeft;
            FlattenSub(oLeft).right = oRight;
            return FlattenSub(oRight);
        }
    }
}
