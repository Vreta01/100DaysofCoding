using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class DPUniquePaths
    {
        //Original answer was too slow tracing each path with larger datasets
        public int UniquePaths(int m, int n)
        {
            var paths = 0;
            TakeStep(0, 0);
            return paths;

            void TakeStep(int mStep, int nStep)
            {
                if (mStep < m - 1)
                { TakeStep(mStep + 1, nStep); }
                if (nStep < n - 1)
                { TakeStep(mStep, nStep + 1); }

                if (mStep == m - 1 && nStep == n - 1)
                { paths++; }

            }
        }
        //Correct answer uses a formula to solve without tracing paths
        public int UniquePathsSolved(int m, int n)
        {
            long answer = 1;
            for (int i = 1; i < m; i++)
            {
                answer *= n + i - 1;
                answer /= i;
            }
            return (int)answer;
        }
    }
