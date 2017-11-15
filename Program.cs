using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many levels to model: ");
            int modelSize = int.Parse(Console.ReadLine());
            Node model = new Node();
            Ball ballModel = new Ball(); 
            for (int i = 1; i <= modelSize + 1; i++)
            {
                model.AddNodes(i);
            }
            List<List<int>> nodes = model.ReturnNodes();
            Console.WriteLine("List of nodes, containing level, node number and gate status.\nA status of 0 means left, a status of 1 means right");
            //nodes.ForEach(i => Console.Write("({0}, {1}, {2})\n", i[0].ToString(), i[1].ToString(), i[2].ToString()));
            model.PredictSystem(nodes, modelSize);
            ballModel.RunSystem(nodes, modelSize);

        }
    }
}
