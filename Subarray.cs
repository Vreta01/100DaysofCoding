using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class Subarray
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            double average = 0;

            for (int i = 0; i < k; i++)
            {
                average += nums[i];
            }

            double slidingSum = average;
            double slidingAverage = 0;

            average = average / k;

            for ( int i = k; i < nums.Length; i++)
            {
                slidingSum += nums[i] - nums[i-k];
                slidingAverage = slidingSum / k;
                if (slidingAverage > average)
                {
                    average = slidingAverage;
                }
            }
            return average;
        }
    }
}
