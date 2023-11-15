using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BinaryTreeLevelSum
    {
        public int MaxLevelSum(TreeNode root)
        {
            int level = 1;
            List<int> scores = new List<int>();
            ThisLevelSum(root, level, scores);
            int max = root.val;
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                    level = i + 1;
                }
            }
            return level;
        }
        public void ThisLevelSum(TreeNode node, int level, List<int> scores)
        {
            if (node == null)
            { return; }
            if (scores.Count < level)
            { scores.Add(node.val); }
            else
            { scores[level - 1] = scores[level - 1] + node.val; }
            if (node.left != null)
            { ThisLevelSum(node.left, level + 1, scores); }
            if (node.right != null)
            { ThisLevelSum(node.right, level + 1, scores); }
        }
    }
}
