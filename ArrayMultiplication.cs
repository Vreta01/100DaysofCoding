using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class ArrayMultiplication
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            int leftSide = 1;
            for (int i = 0; i < n; i++)
            {
                answer[i] = leftSide;
                leftSide *= nums[i];
            }

            int rightSide = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] = rightSide;
                rightSide *= nums[i];
            }

            return answer;
        }
    }
}
