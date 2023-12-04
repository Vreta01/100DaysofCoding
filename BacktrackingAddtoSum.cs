using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BacktrackingAddtoSum
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            List<IList<int>> answer = new();
            Stack<int> stack = new Stack<int>();

            if (k > n)
            { return answer; }
            GetSum(1, k, n);
            return answer;

            void GetSum(int start, int numbersLeft, int targetValue)
            {
                if (targetValue == 0 && numbersLeft == 0) answer.Add(stack.ToArray());
                if (targetValue == 0 || numbersLeft == 0) return;

                for (int i = start; i < 10; i++)
                {
                    stack.Push(i);
                    GetSum(i + 1, numbersLeft - 1, targetValue - i);
                    stack.Pop();
                }
            }
        }
    }
}
