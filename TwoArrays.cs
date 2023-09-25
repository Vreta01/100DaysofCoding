using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class TwoArrays
    {
        public static int LargestAltitude(int[] gain)
        {
            int highestAltitude = 0;
            int currentAltitude = 0;
            foreach (int i in gain)
            {
                currentAltitude += i;
                highestAltitude = Math.Max(highestAltitude, i);
            }
            return highestAltitude;
        }

        public static int PivotIndex(int[] nums)
        {
            int pivotIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                pivotIndex = i;
                int j = nums.Length - 1;
                int k = 0;
                int leftSum = 0;
                int rightSum = 0;
                while (j > pivotIndex)
                {
                    rightSum += nums[j];
                    j--;
                }
                while (k < pivotIndex)
                {
                    leftSum += nums[k];
                    k++;
                }
                if (leftSum == rightSum)
                {
                    return pivotIndex;
                }

            }
            return -1;
        }

        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            int[][] answer = new int[2][];
            answer[0] = nums1.Except(nums2).ToArray();
            answer[1] = nums2.Except(nums1).ToArray();
            return answer;

        }
    }
}
