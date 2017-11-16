using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Container
    {

        List<List<int>> containers = new List<List<int>>();

        /// <summary>
        /// Creates all containers setting them as empty 
        /// </summary>
        /// <param name="level"> the number of levels in the system </param>
        public void CreateContainers(int level)
        {
            double ContainerSize = Math.Pow(2.00, level);
            for (int i = 1; i <= Math.Pow(2.00, level); i++)
            {
                List<int> container = new List<int>();
                container.Add(i);
                container.Add(0);
                containers.Add(container);
            }
        }

        /// <summary>
        /// Finds the container that is left empty at the end
        /// </summary>
        /// <param name="level"> the number of levels in the system </param>
        /// <returns> container left empty</returns>
        public int EmptyContainer(int level)
        {
            int Empty = 0;
            for(int i = 0; i < Math.Pow(2.00, level); i++)
            {
                if (containers[i][1] == 0)
                {

                    Empty = i + 1;
                }
        
            }
            return Empty;
        }

        /// <summary>
        /// Returns the list of containers
        /// </summary>
        /// <returns> list of containers </returns>
        public List<List<int>> ReturnContainer()
        {
            return containers;
        }

        
    }
}
