using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Node

    {
        List<List<int>> nodes;
        public Node()
        {
                nodes = new List<List<int>>();
        }

        public void TreeCreator(int level)
        {
            for (int i = 1; i <= level; i++)
            {
                AddNodes(i);
            }
        }
        /// <summary>
        /// creates the nodes of the tree initializing there gate status
        /// </summary>
        /// <param name="level"> the number of levels in the system </param>
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
                Console.Write("({0}, {1}, {2}) ", node[0].ToString(), node[1].ToString(), node[2].ToString());
            }
            Console.WriteLine("\n");
        }




        /// <summary>
        /// Predicts which container will be left empty
        /// </summary>
        /// <param name="tree"> the list of nodes </param>
        /// <param name="level"> the number of levels in the system </param>
        /// <returns> predicted container </returns>
        public double PredictSystem(List<List<int>> tree, int level)
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
            return nodeIndex + 1 - Math.Pow(2.00, (level));
            

        }




        /// <summary>
        /// returns the list of ndoes
        /// </summary>
        /// <returns> node list </returns>
        public List<List<int>> ReturnNodes()
        {
            return nodes;
        }

       


    }
    
}
