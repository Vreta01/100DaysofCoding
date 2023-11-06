using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BinaryTreePathSum
    {
        /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
        public class Solution
        {
            public int PathSum(TreeNode root, int targetSum)
            {
                if (root == null)
                { return 0; }

                return FindPath(root, targetSum)
                    + PathSum(root.left, targetSum)
                    + PathSum(root.right, targetSum);
            }
            private static int FindPath(TreeNode root, int sum)
            {
                int counter = root.val == sum ? 1 : 0;

                if (root.left != null)
                { counter += FindPath(root.left, sum - root.val); }
                if (root.right != null)
                { counter += FindPath(root.right, sum - root.val); }

                return counter;
            }
        }
    }
}
