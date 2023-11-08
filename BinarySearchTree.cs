using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            { return null; }

            root = CheckNode(root, val);

            if (root.val == val)
            { return root; }
            else
            { return null; }
        }
        public static TreeNode CheckNode(TreeNode node, int val)
        {

            if (node.val < val && node.right != null)
            { node = CheckNode(node.right, val); }
            if (node.val > val && node.left != null)
            { node = CheckNode(node.left, val); }

            return node;
        }
    }
}
