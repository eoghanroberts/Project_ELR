using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Ball
    {
       public void RunSystem(List<List<int>> tree, int level)
        {
            double numOfBalls = Math.Pow(2.00, (level)) - 1;
            for(int i = 1; i <= numOfBalls; i++)
            {
                int nodeIndex = 1;
                for (int j = 1; j < level + 1; j++)
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
                Console.Write("ball {0} landed in container {1}\n", i.ToString(), nodeIndex - 15);

            }

        }

    }
}
