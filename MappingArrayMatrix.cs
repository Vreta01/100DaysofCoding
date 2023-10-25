using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class MappingArrayMatrix
    {
        public static int EqualPairs(int[][] grid)
        {
            int n = grid.Length;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int checkCount = 0;
                    for (int c = 0; c < n; c++)
                    {
                        if (grid[i][c] == grid[c][j])
                        { checkCount++; }
                    }
                    if (checkCount == n)
                    { result++; }
                }
            }
            return result;
        }
    }
}
