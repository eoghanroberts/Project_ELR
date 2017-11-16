using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Ball
    {

        /// <summary>
        /// Runs a calculated number of balls through the system the number of balls is 
        /// based on the number of levels
        /// </summary>
        /// <param name="tree"> the list of nodes </param>
        /// <param name="level"> the number of levels in the system </param>
        /// <param name="Containers"> the list of containers </param>
        public void RunSystem(List<List<int>> tree, int level, List<List<int>> Containers)
        {
            double NumOfBalls = Math.Pow(2.00, (level)) - 1;
            for(int i = 1; i <= NumOfBalls; i++)
            {
                int nodeIndex = 1;
                for (int j = 0; j <= level - 1; j++)
                {
                    if (tree[nodeIndex - 1][2] == 0)
                    {
                        tree[nodeIndex - 1][2] = 1;
                        nodeIndex = (nodeIndex * 2);
                        
                    }
                    else if (tree[nodeIndex - 1][2] == 1)
                    {
                        tree[nodeIndex - 1][2] = 0;
                        nodeIndex = (nodeIndex * 2) + 1;
                       
                    }
                }
                Console.Write("ball {0} landed in container {1}\n", i.ToString(), nodeIndex + 1 - Math.Pow(2.00, (level)));
                FillContainer(nodeIndex - (int)Math.Pow(2.00, (level)), Containers);
            }

        }

        /// <summary>
        /// Shows the process of a ball entering a container
        /// </summary>
        /// <param name="Container"> the container being filled </param>
        /// <param name="Containers"> the list of containers </param>
        public void FillContainer(int Container, List<List<int>> Containers)
        {
            Containers[Container][1] = 1;
        }

    }
}
