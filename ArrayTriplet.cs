using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class ArrayTriplet
    {
        public static bool IncreasingTriplet(int[] nums)
        {
            int n = nums.Length;
            int small = int.MaxValue;
            int smallest = int.MaxValue;

            if (n < 3)
            { return false; }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] <= smallest)
                { smallest = nums[i]; }
                else if (nums[i] <= small)
                { small = nums[i]; }
                else
                { return true; }
            }

            return false;
        }
    }
}
