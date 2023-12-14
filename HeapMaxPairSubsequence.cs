using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class HeapMaxPairSubsequence
    {
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            int n = nums1.Length;
            (int, int)[] nums12 = new (int, int)[n];

            for (int i = 0; i < n; i++)
            { nums12[i] = (nums1[i], nums2[i]); }

            Array.Sort(nums12, (a, b) => b.Item2.CompareTo(a.Item2));

            PriorityQueue<int, int> pQueue = new();
            long result = 0;
            long currentSum = 0;

            for (int i = 0; i < n; i++)
            {
                pQueue.Enqueue(nums12[i].Item1, nums12[i].Item1);
                currentSum += nums12[i].Item1;

                if (pQueue.Count > k)
                { currentSum -= pQueue.Dequeue(); }
                if (pQueue.Count == k)
                { result = Math.Max(result, currentSum * nums12[i].Item2); }
            }
            return result;
        }
    }
}
