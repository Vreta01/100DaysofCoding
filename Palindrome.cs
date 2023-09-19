using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            string s2 = "";
            string s3 = "";

            List<string> checkList = new List<string> {"0","1","2","3","4","5","6","7","8","9","0","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};

    

            foreach (char c in s)
            {
                string c2 = c.ToString().ToLower();
                if (checkList.Contains(c2))
                {
                    s2 = s2 + c2;
                    Console.WriteLine(s2);
                }
            }
            Console.WriteLine(s2);

            for (int i = s2.Length - 1; i >= 0; i--)
            {
                s3 = s3 + s2[i];
                
            }
            Console.WriteLine(s3);
            if (s2 == s3)
            { return true; }
            else { return false; }
            


        }
    }
}
