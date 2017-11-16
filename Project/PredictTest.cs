using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class PredictTest
    {
        /// <summary>
        /// Checks where the prediction was correct
        /// </summary>
        /// <param name="Prediction"> the predicted value </param>
        /// <param name="Empty"> the actual value </param>
        public void PredictionChecker(double Prediction, int Empty)
        {
            if (Empty == Prediction)
            {
                Console.WriteLine("The prediction was correct");
            }
        }
    }
}
