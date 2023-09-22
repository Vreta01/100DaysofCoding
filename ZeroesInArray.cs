using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class ZeroesInArray
    {
        public static void MoveZeroes(int[] nums)
        {
            int ptr1;
            int ptr2;
            int i2;
            int n = nums.Length;

            for (int i = 0; i < n - 1; i++)
            {
                
                if (nums[i] == 0)
                {
                    ptr1 = i;
                    i2 = i;

                    do
                    {
                        i++;
                        ptr2 = nums[i];

                        if (ptr2 != 0)
                        {
                            nums[i] = nums[ptr1];
                            nums[ptr1] = ptr2;
                            ptr1 = i;
                        }

                    }
                    while (nums[i] == 0 && i < n - 1);
                    i = i2;
                }
            }
        }
    }
}
