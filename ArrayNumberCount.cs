using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class ArrayNumberCount
    {
        public static bool UniqueOccurences(int[] arr)
        {
            
            List<int> counts = new List<int>();
            List<int> numbers = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int currentValue = arr[i];
                int currentCount = 0;
                if (!numbers.Contains(currentValue))
                {
                    foreach (int number in arr)
                    {
                        if (number == currentValue)
                        { currentCount++; }
                    }

                    if (counts.Contains(currentCount))
                    { return false; }
                    else
                    {
                        counts.Add(currentCount);
                        numbers.Add(currentValue);
                    }
                }

            }
            return true;
        }
    }
}
