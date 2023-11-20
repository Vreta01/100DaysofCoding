using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class GraphVisitingVertices
    {
        public class Solution
        {
            public bool CanVisitAllRooms(IList<IList<int>> rooms)
            {
                if (rooms == null)
                { return false; }

                int n = rooms.Count;
                bool[] visited = new bool[n];

                VisitNextRoom(0);

                if (!Array.Exists(visited, element => element == false))
                { return true; }
                else
                { return false; }


                void VisitNextRoom(int room)
                {
                    if (visited[room])
                    { return; }

                    visited[room] = true;

                    foreach (int key in rooms[room])
                    { VisitNextRoom(key); }
                }
            }

        }
    }
}
