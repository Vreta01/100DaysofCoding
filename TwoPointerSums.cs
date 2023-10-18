using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class TwoPointerSums
    {
        public int MaxOperations(int[] nums, int k)
        {

            int count = 0;

            Array.Sort(nums);

            int ptrStart = 0;
            int ptrNext = nums.Length - 1;
            int sum = 0;

            while (ptrNext > ptrStart)
            {
                sum = nums[ptrStart] + nums[ptrNext];
                if (sum < k)
                {
                    ptrStart++;
                }
                else if (sum > k)
                {
                    ptrNext--;
                }
                else if (sum == k)
                {
                    nums[ptrStart] = -1;
                    nums[ptrNext] = -1;
                    ptrStart++;
                    ptrNext--;
                    count++;
                }
            }
            return count;
        }
    }
}
