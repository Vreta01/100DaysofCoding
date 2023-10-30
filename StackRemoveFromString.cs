using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class StackRemoveFromString
    {
        //Solution without a stack
        public string RemoveStars(string s)
        {
            int n = s.Length;
            int starCount = 0;
            string response = "";
            char[] inputChars = s.ToCharArray();

            for (int i = n - 1; i >= 0; i--)
            {

                if (inputChars[i] == '*')
                {
                    starCount++;
                }
                if (inputChars[i] != '*' && starCount == 0)
                {
                    response = inputChars[i].ToString() + response;
                }
                if (starCount > 0)
                {
                    if (inputChars[i] != '*')
                    { starCount--; }
                }
            }
            return response;
        }

        //Solution with a stack
        public string RemoveStarsStack(string s)
        {
            int n = s.Length;
            Stack<char> charStack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '*')
                {
                    charStack.Pop();
                }
                if (c != '*')
                {
                    charStack.Push(c);
                }
            }
            return new string(charStack.Reverse().ToArray());
        }
    }
}
