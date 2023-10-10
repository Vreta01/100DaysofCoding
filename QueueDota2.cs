using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class QueueDota2
    {
        public static string PredictPartyVictory(string senate)
        {
            int counter = 0;
            

            while (senate.Contains('R') && senate.Contains('D'))
            {
                int nextIndex = -1;
                if (senate.Substring(counter, 1) == "R")
                {
                    nextIndex = senate.IndexOf('D', counter + 1);
                    if (nextIndex == -1)
                    { nextIndex = senate.IndexOf('D'); counter--; }
                }
                else
                {
                    nextIndex = senate.IndexOf('R', counter + 1);
                    if (nextIndex == -1)
                    { nextIndex = senate.IndexOf('R'); counter--; }
                }
                if (nextIndex >= 0)
                { senate = senate.Remove(nextIndex, 1); }
                counter++;
                if (counter >= senate.Length)
                { counter = 0; }    
            }
            return senate.Substring(0,1) == "R" ? "Radiant" : "Dire";

        }
    }
}
