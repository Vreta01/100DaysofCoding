using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class HeapSmallestInfiniteSet
    {
        private HashSet<int> hash;
        private PriorityQueue<int, int> heap;
        private int count;

        public HeapSmallestInfiniteSet()
        {
            hash = new HashSet<int>();
            heap = new PriorityQueue<int, int>();
            count = 0;
        }

        public int PopSmallest()
        {
            count++;
            heap.Enqueue(count, count);
            int removed = heap.Dequeue();
            hash.Add(removed);
            return removed;

        }

        public void AddBack(int num)
        {
            if (hash.Contains(num))
            {
                heap.Enqueue(num, num);
                hash.Remove(num);
            }

        }
    }
}
