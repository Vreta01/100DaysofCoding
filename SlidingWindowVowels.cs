using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class SlidingWindowVowels
    {
        public static int MaxVowels(string s, int k)
        {
            int maxVowels = 0;
            int currentVowels = 0;

            for (int ptr = 0; ptr < s.Length; ptr++)
            {
                if (ptr < k)
                {
                    if (IsVowel(s[ptr]))
                    { currentVowels++; }
                }
                else
                {
                    if (IsVowel(s[ptr - k]))
                    { currentVowels--; }
                    if (IsVowel(s[ptr]))
                    { currentVowels++; }
                }
                maxVowels = Math.Max(maxVowels, currentVowels);
            }
            return maxVowels;
        }

        public static bool IsVowel(char c)
        {
            return (c == 'a' || c == 'e' ||  c == 'i' || c == 'o' || c == 'u');
        }
    }
}
