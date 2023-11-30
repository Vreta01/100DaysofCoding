using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class DPRobbingHouses
    {
        public int Rob(int[] nums)
        {
            int ptr1 = nums[0];
            int ptr2 = 0;

            if (nums.Length < 3)
            {
                Array.Sort(nums);
                Array.Reverse(nums);
                return nums[0];
            }

            for (int i = 1; i < nums.Length; i++)
            {
                int t = ptr1;
                ptr1 = Math.Max(ptr1, ptr2 + nums[i]);
                ptr2 = t;
            }
            return ptr1;
        }
    }
}
