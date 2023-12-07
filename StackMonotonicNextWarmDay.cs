using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class StackMonotonicNextWarmDay
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int n = temperatures.Length;
            if (temperatures.Length < 2)
            { return new int[n]; }

            Stack<int> stackOfIndex = new Stack<int>();
            int[] holding = new int[n];

            for (int i = 0; i < n; i++)
            {
                while (stackOfIndex.Count != 0 && temperatures[stackOfIndex.Peek()] < temperatures[i])
                {
                    holding[stackOfIndex.Peek()] = i - stackOfIndex.Peek();
                    stackOfIndex.Pop();
                }
                stackOfIndex.Push(i);
            }
            return holding;

        }
    }
}
