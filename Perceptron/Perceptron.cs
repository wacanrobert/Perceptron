using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    public class Perceptron
    {
        double[] weights;
        double bias;
        double learningRate;
        int epochLimit;

        public Perceptron()
        {
            weights = new double[2];
            bias = -0.5;
            learningRate = 0.1;
            epochLimit = 10;
        }

        public Perceptron(double[] weights, double learningRate, int epochLimit)
        {
            this.weights = weights;
            this.bias = 0.5;
            this.learningRate = learningRate;
            this.epochLimit = epochLimit;
        }

        public int CalculateOutput(int[] x)
        {
            double weightedSum = 0;

            for (int i = 0; i < 2; i++)
                weightedSum += x[i] * weights[i];
            weightedSum += bias;

            if(weightedSum > 0 ) 
            {
                return 1;
            }
            return 0; ;
        }

        public void Train(int[] x, int target)
        {
            double totalError = 0;
            for (int i = 0; i < epochLimit; i++)
            {
                int output = CalculateOutput(x);
                int error = target - output;


                weights[0] += error * x[0] * learningRate;
                weights[1] += error * x[1] * learningRate;

                bias += error * learningRate;

                totalError += Math.Abs(error);

                if (totalError == 0)
                    break;
            }

        }
    }
}
