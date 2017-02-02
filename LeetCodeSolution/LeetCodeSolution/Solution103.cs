using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution103
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {

            Stack<TreeNode> lStack = new Stack<TreeNode>();
            Stack<TreeNode> rStack = new Stack<TreeNode>();
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            lStack.Push(root);

            while (true)
            {
                List<int> currentResult = zigzagResult(lStack, rStack);
                if (currentResult == null)
                { break; }

                result.Add(currentResult);
            }

            return result;
        }

        public List<int> zigzagResult(Stack<TreeNode> l, Stack<TreeNode> r)
        {   // process nodes in one lv
            // one of the stack must be empty

            List<int> result = new List<int>();
            if (l.Count == 0 && r.Count == 0)
            {
                return null;
            }

            if (l.Count != 0)
            {
                while (l.Count != 0)
                {
                    //left to right
                    TreeNode t = l.Pop();
                    result.Add(t.val);
                    if (t.left != null)
                    { r.Push(t.left); }
                    if (t.right != null)
                    { r.Push(t.right); }
                }
            }
            else
            {
                while (r.Count != 0)
                {
                    // right to left
                    TreeNode t = r.Pop();
                    result.Add(t.val);
                    if (t.right != null)
                    { l.Push(t.right); }
                    if (t.left != null)
                    { l.Push(t.left); }
                }
            }
            return result;

        }
    }
}
