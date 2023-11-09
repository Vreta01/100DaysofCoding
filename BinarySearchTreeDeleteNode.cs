using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BinarySearchTreeDeleteNode
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            return FindNode(root, key);

        }
        public static TreeNode FindNode(TreeNode node, int key)
        {
            if (node == null)
            { return null; }

            node.left = FindNode(node.left, key);
            node.right = FindNode(node.right, key);

            if (node.val != key)
            { return node; }

            if (node.right == null)
            { return node.left; }

            if (node.left == null)
            { return node.right; }

            return MoveLToR(node);
        }
        public static TreeNode MoveLToR(TreeNode node)
        {
            TreeNode left = node.left;
            TreeNode baseRight = node.right;
            TreeNode right = node.right;

            while (right.left != null)
            {
                right = right.left;
            }
            right.left = left;

            return baseRight;
        }
    }
}
