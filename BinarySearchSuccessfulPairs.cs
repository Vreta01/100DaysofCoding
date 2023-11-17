using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BinarySearchSuccessfulPairs
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            int n = spells.Length;
            int m = potions.Length;
            Array.Sort(potions);
            int[] pairs = new int[n];

            for (int i = 0; i < n; i++)
            {
                int left = 0;
                int right = m - 1;
                int mostLeft = -1;

                while (left <= right)
                {
                    int j = (left + right) / 2;
                    if (((long)spells[i]) * potions[j] >= success)
                    {
                        mostLeft = j;
                        right = j - 1;
                    }
                    else
                    { left = j + 1; }
                }
                pairs[i] = mostLeft == -1 ? 0 : potions.Length - mostLeft;
            }
            return pairs;
        }
    }
}
