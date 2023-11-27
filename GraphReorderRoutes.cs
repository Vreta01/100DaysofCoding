using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class GraphReorderRoutes
    {
  
            public int MinReorder(int n, int[][] connections)
            {
                if (connections.Length == 0)
                { return 0; }
                int counter = 0;
                List<List<(int sign, int road)>> adj = new();
                for (int i = 0; i < n; i++)
                { adj.Add(new List<(int sign, int road)>()); }

                foreach (int[] node in connections)
                {
                    adj[node[0]].Add((1, node[1]));
                    adj[node[1]].Add((0, node[0]));
                }
                DFS(0, -1);
                return counter;

                void DFS(int node, int parent)
                {
                    foreach ((int sign, int road) pair in adj[node])
                    {
                        if (pair.road == parent)
                        { continue; }
                        counter += pair.sign;
                        DFS(pair.road, node);
                    }

                }
            }
    }
}
