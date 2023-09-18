using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class StocksIII
    {
        public static int MaxProfit(int[] prices)
        {
            int[] leftProfit = new int[prices.Length];
            int[] rightProfit = new int[prices.Length];
            int min;
            int max;
            if (prices.Length == 0)
            { return 0; }

            min = prices[0];
            max = prices[0];


            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                { max = min = prices[i]; }
                max = Math.Max(prices[i], max);
                leftProfit[i] = Math.Max(leftProfit[i - 1], max - min);
            }

            min = prices[(prices.Length - 1)];
            max = prices[(prices.Length - 1)];
            for (int i = (prices.Length - 2); i >= 0; i--)
            {
                if (prices[i] > max)
                { max = min = prices[i]; }
                min = Math.Min(prices[i], min);
                rightProfit[i] = Math.Max(rightProfit[i + 1], max - min);
            }

            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                maxProfit = Math.Max(maxProfit, leftProfit[i] + rightProfit[i]);
            }
            return maxProfit;
        }
    }
}
