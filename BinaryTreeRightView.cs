using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BinaryTreeRightView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> answers = new List<int>();
            int height = 1;
            if (root == null)
            { return answers; }
            Helper(root, answers, height);
            return answers;
        }
        public static void Helper(TreeNode node, List<int> answers, int height)
        {
            if (node == null)
            { return; }
            if (height > answers.Count)
            {
                answers.Add(node.val);
            }
            height++;
            Helper(node.right, answers, height);
            Helper(node.left, answers, height);

        }
    }
}
