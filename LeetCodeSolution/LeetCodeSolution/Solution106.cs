using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution106
    {
        #region time limit exceeded since we are copying the subarray again and again

        //public TreeNode BuildTree(int[] inorder, int[] postorder)
        //{
        //    if(inorder.Length == 0)
        //    {
        //        return null;
        //    }

        //    if(inorder.Length == 1)
        //    {
        //        return new TreeNode(inorder[0]);
        //    }

        //    TreeNode root = new TreeNode(postorder[postorder.Length - 1]);
        //    int LeftLength = inorder.ToList().FindIndex(t=>t == root.val);
        //    int RightLength = inorder.Length - LeftLength - 1;

        //    root.left = BuildTree(inorder.Take(LeftLength).ToArray(), postorder.Take(LeftLength).ToArray());
        //    root.right = BuildTree(inorder.Skip(LeftLength + 1).Take(RightLength).ToArray(), postorder.Skip(LeftLength).Take(RightLength).ToArray());

        //    return root;
        //}
        #endregion

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder.Length == 0)
            {
                return null;
            }

            if (inorder.Length == 1)
            {
                return new TreeNode(inorder[0]);
            }

            TreeNode root = new TreeNode(postorder[postorder.Length - 1]);
            int LeftLength = inorder.ToList().FindIndex(t => t == root.val);
            int RightLength = inorder.Length - LeftLength - 1;

            root.left = BuildSubTree(inorder, postorder, 0, 0, LeftLength);
            root.right = BuildSubTree(inorder, postorder, LeftLength + 1, LeftLength, RightLength);

            return root;
        }

        public TreeNode BuildSubTree(int[] inorder, int[] postorder, int inStart, int Pstart, int length)
        {
            if(length == 0)
            {
                return null;
            }

            if (length == 1)
            {
                return new TreeNode(inorder[inStart]);
            }

            TreeNode root = new TreeNode(postorder[Pstart + length - 1]);
            int indexInOrder = inorder.ToList().FindIndex(t => t == root.val);
            int LeftLength = indexInOrder - inStart;
            int RightLength = length - LeftLength - 1;

            root.left = BuildSubTree(inorder, postorder, inStart, Pstart, LeftLength);
            root.right = BuildSubTree(inorder, postorder, indexInOrder + 1, Pstart + LeftLength, RightLength);

            return root;

        }

    }
}
