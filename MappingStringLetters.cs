using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class MappingStringLetters
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length == word2.Length)
            {
                int[] letter1Freq = new int[26];
                int[] letter2Freq = new int[26];

                foreach (char letter in word1)
                {
                    letter1Freq[letter - 'a']++;
                }

                foreach (char letter in word2)
                {
                    letter2Freq[letter - 'a']++;
                }

                for (int i = 0; i < 26; i++)
                {
                    if ((letter1Freq[i] == 0) != (letter2Freq[i] == 0))
                    { return false; }
                }

                Array.Sort(letter1Freq);
                Array.Sort(letter2Freq);
                for (int i = 0; i < 26; i++)
                {
                    if (letter1Freq[i] != letter2Freq[i])
                    { return false; }
                }
            }
            else
            { return false; }

            return true;
        }
    }
}
