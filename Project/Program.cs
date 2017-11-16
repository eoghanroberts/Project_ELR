using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Program
    {
        /// <summary>
        /// Runs the whole program, printing the information and prompts
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("How many levels to model: ");
            int modelSize = int.Parse(Console.ReadLine());
            Node model = new Node();
            Ball ballModel = new Ball();
            Container container = new Container();
            PredictTest PredictCheck = new PredictTest();

            Console.WriteLine("List of nodes, containing level, node number and gate status.\nA status of 0 means left, a status of 1 means right." +
                "\nThe bottom row are containers when the containing both the container number and the number of balls in that container.");
            model.TreeCreator(modelSize);
            List<List<int>> nodes = model.ReturnNodes();
            container.CreateContainers(modelSize);
            List<List<int>> containers = container.ReturnContainer();
            containers.ForEach(i => Console.Write("({0}, {1})  ", i[0].ToString(), i[1].ToString()));
            double Prediction = model.PredictSystem(nodes, modelSize);
            Console.Write("\nThe predicted container to contain no ball is : {0}\n", Prediction);
            ballModel.RunSystem(nodes, modelSize, containers);
            containers.ForEach(i => Console.Write("({0}, {1})  ", i[0].ToString(), i[1].ToString()));
            int Empty = container.EmptyContainer(modelSize);
            Console.Write("\nThe container left with no ball is {0}\n", Empty);
            PredictCheck.PredictionChecker(Prediction, Empty);
        }
  
    }
}
