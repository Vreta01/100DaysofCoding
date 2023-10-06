using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class StringSqueeze
    {
        public int Compress(char[] chars)
        {
            int i = 0;
            int j = 0;

            while (i < chars.Length)
            {
                char charsLetter = chars[i];
                int counter = 0;

                while (i < chars.Length && chars[i] == charsLetter)
                {
                    i++;
                    counter++;
                }
                chars[j++] = charsLetter;

                if (counter > 1)
                {
                    foreach (var item in counter.ToString())
                    { chars[j++] = item; }
                }
            }
            return j;
        }
    }
}
