using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution173
    {
        /**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */
    }

    public class BSTIterator
    {
        private Stack<TreeNode> stack = new Stack<TreeNode>();
        public BSTIterator(TreeNode root)
        {
            pushAllLeftNodes(root);
        }

        private void pushAllLeftNodes(TreeNode root)
        {
            while(root != null)
            {
                stack.Push(root);
                root = root.left;
            }
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return stack.Count > 0;
        }

        /** @return the next smallest number */
        public int Next()
        {
            TreeNode t = stack.Pop();
            pushAllLeftNodes(t.right);
            return t.val;
        }
    }


}
