using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class Flowers
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int iBefore = 0;
            int iAfter = 0;
            int flowerCount = 0;

            if (n == 0)
            { return true; }
            if (flowerbed.Length == 1)
            {
                if (flowerbed[0] == 0)
                { flowerCount++; }
            }
            else
            {
                for (int i = 0; i < flowerbed.Length; i++)
                {

                    iBefore = i - 1;
                    iAfter = i + 1;
                    if (iBefore < 0 && iAfter < flowerbed.Length)
                    {
                        if (flowerbed[i] == 0 && flowerbed[iAfter] == 0)
                        {
                            flowerbed[i] = 1;
                            flowerCount++;
                        }
                    }
                    if (iAfter >= flowerbed.Length && iBefore >= 0)
                    {
                        if (flowerbed[iBefore] == 0 && flowerbed[i] == 0)
                        {
                            flowerbed[i] = 1;
                            flowerCount++;
                        }
                    }
                    if (iBefore >= 0 && iAfter < flowerbed.Length)
                    {
                        if (flowerbed[iBefore] == 0 && flowerbed[i] == 0 && flowerbed[iAfter] == 0)
                        {
                            flowerbed[i] = 1;
                            flowerCount++;
                        }
                    }
                }
            }
            if (flowerCount >= n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
