using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) 
            {
                this.val = val;
                this.left = left;
                this.right = right;

            }
    internal class BinaryTreeMethods
    {
            public static int MaxDepth(TreeNode root)
            {
                if (root == null)
                    { return 0; }
                int max = 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));

                return max;
            }

    }
}
