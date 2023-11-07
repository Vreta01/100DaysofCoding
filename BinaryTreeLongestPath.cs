using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BinaryTreeLongestPath
    {
        public int LongestZigZag(TreeNode root)
        {

            int left = ZigOrZag(root, true, 0);
            int right = ZigOrZag(root, false, 0);
            int answer = Math.Max(left, right);
            return answer - 1;

        }
        public static int ZigOrZag(TreeNode node, bool isLeft, int length)
        {
            if (node == null)
            { return length; }
            int current = isLeft ? ZigOrZag(node.right, !isLeft, length + 1) : ZigOrZag(node.left, !isLeft, length + 1);
            int alternate = isLeft ? ZigOrZag(node.left, isLeft, 1) : ZigOrZag(node.right, isLeft, 1);
            int maxLength = Math.Max(current, alternate);
            return maxLength;
        }
    }
}
