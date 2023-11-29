using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class BacktrackingLetterCombos
    {
        Dictionary<char, string> map = new()
        {
            {'2', "abc"},{'3',"def"},{'4',"ghi"},
            {'5',"jkl"},{'6',"mno"},{'7',"pqrs"},{'8',"tuv"},{'9',"wxyz"}
        };

        public IList<string> LetterCombinations(string digits)
        {
            List<string> combos = new();

            if (digits.Length == 0)
            {
                return combos;
            }

            foreach (var c in map[digits[0]])
            {
                if (digits.Length == 1)
                {
                    combos.Add(c.ToString());
                }
                else
                {
                    foreach (var combo in LetterCombinations(digits.Substring(1)))
                    {
                        combos.Add(c.ToString() + combo);
                    }
                }
            }

            return combos;

        }

    }
}
