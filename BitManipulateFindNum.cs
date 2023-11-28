using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BitManipulateFindNum
    {
        public int SingleNumber(int[] nums)
        {
            List<int> countedNumbers = new List<int>();

            foreach (int number in nums)
            {
                if (countedNumbers.Contains(number))
                { countedNumbers.Remove(number); }
                else
                { countedNumbers.Add(number); }
            }
            return countedNumbers[0];

        }

        public int SingleNumberBitPath(int[] nums)
        {
            var result = 0;
            foreach (var number in nums)
            { result ^= number; }
            return result;
        }
    }
}
