using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class DPTribonacciSequence
    {
        public int Tribonacci(int n)
        {
            if (n == 0)
            { return 0; }
            if (n == 1 || n == 2)
            { return 1; }

            int i = 2;
            List<int> answer = new List<int> { 0, 1, 1 };
            while (i < n)
            {
                answer.Add(answer[0] + answer[1] + answer[2]);
                answer.RemoveAt(0);
                i++;
            }
            return answer[2];
        }
    }
}
