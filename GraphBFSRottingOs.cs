using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class GraphBFSRottingOs
    {
        public int OrangesRotting(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;
            int freshOs = 0;

            int[] rowRot = { -1, 0, 1, 0 };
            int[] colRot = { 0, 1, 0, -1 };

            Queue<int[]> queue = new Queue<int[]>();

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < m; column++)
                {
                    if (grid[row][column] == 2)
                    { queue.Enqueue(new int[] { row, column, 0 }); }
                    else if (grid[row][column] == 1)
                    { freshOs++; }
                }
            }

            int minutes = 0;
            while (queue.Count > 0)
            {
                int[] current = queue.Dequeue();
                int row = current[0];
                int column = current[1];
                int count = current[2];

                minutes = count;

                for (int i = 0; i < 4; i++)
                {
                    int nI = row + rowRot[i];
                    int mI = column + colRot[i];

                    if (mI >= 0 && mI < m && nI >= 0 && nI < n && grid[nI][mI] == 1)
                    {
                        grid[nI][mI] = 2;
                        freshOs--;
                        queue.Enqueue(new int[] { nI, mI, count + 1 });
                    }
                }
            }
            return freshOs == 0 ? minutes : -1;
        }
    }
}
