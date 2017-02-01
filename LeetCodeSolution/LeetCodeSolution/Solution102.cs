using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            List<TreeNode> current = new List<TreeNode>();
            List<TreeNode> children;
            current.Add(root);

            while(current.Count != 0)
            {
                result.Add(PrintAllNodes(current, out children));
                current = children;
            }

            return result;

        }

        public IList<int> PrintAllNodes( List<TreeNode> nodes, out List<TreeNode> children )
        {
            List<int> result = new List<int>();
            children = new List<TreeNode>();

            foreach ( TreeNode n in nodes)
            {
                result.Add(n.val);
                if(n.left!=null)
                {
                    children.Add(n.left);
                }

                if(n.right!=null)
                {
                    children.Add(n.right);
                }
            }

            return result;
        }
    }
    
}
