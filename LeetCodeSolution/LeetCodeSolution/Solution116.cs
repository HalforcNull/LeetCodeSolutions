using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution116
    {
        //this question has no C# solution option.
        // ganna provide c solution and c# solution
        public void connect(TreeLinkNode root)
        {
            if (root == null)
            {
                return;
            }
            root.next = null;
            ConnectChildren(root);
        }

        public void ConnectChildren(TreeLinkNode current)
        {
            if (current == null || current.left == null)
            { return; }
            current.left.next = current.right;
            if (current.next == null)
            {
                current.right.next = null;
            }
            else
            {
                current.right.next = current.next.left;
            }

            ConnectChildren(current.left);
            ConnectChildren(current.right);
        }
    }

    public class TreeLinkNode
    {
        int val;
        public TreeLinkNode left, right, next;

        public TreeLinkNode(int x) { val = x; }
    }

    #region C Solution - Passed
    //    void connectChildren( struct TreeLinkNode * current)
    //{
    //    if(current == NULL||current->left == NULL)
    //    { return; }

    //current->left->next = current->right;

    //    if(current->next == NULL)
    //    {
    //        current->right->next = NULL;
    //    }
    //    else
    //    {
    //        current->right->next = current->next->left;
    //    }


    //    connectChildren(current->left);
    //    connectChildren(current->right);
    //}

    //void connect(struct TreeLinkNode * root) {
    //    if(root == NULL)
    //    {return;}

    //    root->next = NULL;
    //    connectChildren(root);
    //}
    #endregion
}
