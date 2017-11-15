using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Node

    {
        public void AddNodes(int level)
        {
            int levels = level;
            double numOfNodes = Math.Pow(2.00, (levels - 1));
            Random rnd = new Random();
            for (int i = 0; i < numOfNodes; i++)
            {
                
                int gate = rnd.Next(0, 2); //0 means left, 1 means right 
                List<int> node = new List<int>();
                node.Add(levels);
                node.Add((int)numOfNodes + i);
                node.Add(gate);
                nodes.Add(node);
                Console.Write("({0}, {1}, {2})  ", node[0].ToString(), node[1].ToString(), node[2].ToString());
            }
            Console.WriteLine("\n");
    }

        public List<List<int>> ReturnNodes()
        {
            return nodes;
        }

        public void PredictSystem(List<List<int>> tree, int level)
        {
            int nodeIndex = 1;
            for(int i = 1; i < level + 1; i++)
            {
                if (tree[nodeIndex - 1][2] == 0)
                {
                    nodeIndex = (nodeIndex * 2) + 1;
                } else if (tree[nodeIndex - 1][2] == 1)
                {
                    nodeIndex = (nodeIndex * 2);
                }
            }
            Console.Write("The predicted container to contain no ball is : {0}\n", nodeIndex - 15);

        }
        List<List<int>> nodes = new List<List<int>>();
    }
    
}
