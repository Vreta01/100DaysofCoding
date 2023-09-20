using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class GCDofStrings
    {
        public static string FindGCD(string str1, string str2)
        {           
            string x = "";
            string smallerString = "";
            string largerString = "";
            int smallerSize = 0;
            int largerSize = 0;

            if (str1.Length >= str2.Length)
            {
                smallerSize = str2.Length;
                smallerString = str2;
                largerSize = str1.Length;
                largerString = str1;
            }
            else
            {
                smallerSize = str1.Length;
                smallerString = str1;
                largerSize = str2.Length;
                largerString = str2;
            }

            string xx = smallerString;
            if (xx == largerString)
            {
                return smallerString;
            }

            for (int i = smallerSize; i > 0; i--)
            {

                xx = smallerString.Substring(0, i);
                x = xx;
                bool fitsInSmall = false;
                while (xx.Length < largerSize)
                {
                    xx += x;
                    if (xx == smallerString || x == smallerString)
                    { fitsInSmall = true; }
                }
                if (xx == largerString && fitsInSmall)
                {
                    return x;
                }
            }

            x = "";
            return x;
        }
    }
}
