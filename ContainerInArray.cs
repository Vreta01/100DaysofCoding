using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class ContainerInArray
    {
        public static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int max = 0;

            while (left < right)
            {
                max = Math.Max(max, ((right - left) * Math.Min(height[left], height[right])));

                if (height[left] <= height[right])
                { left++; }
                else
                { right--; }

            }

            return max;
        }
    }
}
