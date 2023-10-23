using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class SlidingWindowSubarray
    {
        public int LongestSubarray(int[] nums)
        {
            int zeros = 0;
            int windowSize = 0;
            int start = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                zeros += (nums[i] == 0 ? 1 : 0);

                while (zeros > 1)
                {
                    zeros -= (nums[start] == 0 ? 1 : 0);
                    start++;
                }

                windowSize = Math.Max(windowSize, i - start);
            }
            return windowSize;
        }
    }
}
