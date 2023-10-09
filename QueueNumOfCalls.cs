using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class QueueNumOfCalls
    {

        int[]? listOfPings;
        int pingIndex;

        public void RecentCounter()
        {

            listOfPings = new int[10000];
            pingIndex = 0;

        }

        public int Ping(int t)
        {

            listOfPings[pingIndex++] = t;
            int left = t - 3000;
            int center = 1;

            for (int i = pingIndex - 2; i >= 0; i--)
            {
                if (listOfPings[i] < left)
                { return center; }
                center++;
            }
            return center;
        }
    }
}
