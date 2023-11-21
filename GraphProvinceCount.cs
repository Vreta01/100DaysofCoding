using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class GraphProvinceCount
    {

        int[] parent = Array.Empty<int>();
        public int FindCircleNum(int[][] isConnected)
        {
            int n = isConnected.Length;
            parent = new int[n];

            for (int i = 0; i < n; i++)
            { parent[i] = i; }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (isConnected[i][j] == 1)
                    { Union(i, j); }
                }
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (FindRoot(i) == i)
                { count++; }
            }
            return count;
        }
        private int FindRoot(int x)
        {
            if (parent[x] != x)
            { parent[x] = FindRoot(parent[x]); }
            return parent[x];
        }
        private void Union(int x, int y)
        {
            parent[FindRoot(x)] = parent[FindRoot(y)];
        }

    }
}
