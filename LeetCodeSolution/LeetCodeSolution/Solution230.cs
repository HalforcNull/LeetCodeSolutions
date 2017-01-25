using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution230
    {
        public int KthSmallest(TreeNode root, int k)
        {
            List<int> allValues = new List<int>();
            addValues(root, ref allValues);

            return allValues[k-1];

        }

        private void addValues(TreeNode root, ref List<int> valueList)
        {
            if(root.left != null)
            {
                addValues(root.left, ref valueList);
            }
            valueList.Add(root.val);
            if (root.right != null)
            {
                addValues(root.right, ref valueList);
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}
