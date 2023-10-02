using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class ReverseWordsInAString
    {
        public static string ReverseWords(string s)
        {
            s = s.Trim();
            string s2 = s;
            string reversedString = "";
            

            while (s2.LastIndexOf(' ') != -1)
            {
                int spaceIndex = s2.LastIndexOf(' ');
                reversedString += s2.Substring(spaceIndex + 1) + " ";
                s2 = s2.Substring(0, spaceIndex);
                s2 = s2.Trim();
            }
            reversedString += s2;
            reversedString = reversedString.Trim();
            return reversedString;
        }
    }
}
