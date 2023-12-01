using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BinarySearchFindPeak
    {
        public int FindPeakElement(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left + 1 < right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] < nums[mid + 1])
                { left = mid; }
                else
                { right = mid; }
            }
            if (nums[left] < nums[right])
            { return right; }
            else
            { return left; }
        }
    }
}
