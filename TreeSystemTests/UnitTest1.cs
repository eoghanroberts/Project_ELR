using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeSystemTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumberOfNodesTest()
        {
            Node Node = new Node();
            Node.AddNodes(4);
            List<List<int>> NodesTest = Node.ReturnNodes();
            int Actual;
            Actual = NodesTest.Count;
            double Expected = 8;
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void PredictionTest()
        {
            Node Node = new Node();
            Node.TreeCreator(4);
            List<List<int>> PredictionTest = Node.ReturnNodes();
            for(int i = 0; i < 15; i++)
            {
                PredictionTest[i][2] = 1;
            }
            double Actual = Node.PredictSystem(PredictionTest, 4);
            double Expected = 1;
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void NumberOfContainersTest()
        {
            Container Container = new Container();
            Container.CreateContainers(4);
            List<List<int>> ContainersTest = Container.ReturnContainer();
            int Actual;
            Actual = ContainersTest.Count;
            double Expected = 16;
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void SystemRunTest()
        {
            Node Node = new Node();
            Node.TreeCreator(4);
            Container Container = new Container();
            Ball ballModel = new Ball();
            Container.CreateContainers(4);
            ballModel.RunSystem(Node.ReturnNodes(), 4, Container.ReturnContainer());
            int Empty = 0;
            for (int i = 0; i < 16; i++)
            {
                if (Container.ReturnContainer()[i][1] == 0)
                {
                    Empty++;
                }
            }
            Assert.AreEqual(1, Empty);
        }
    }
}
