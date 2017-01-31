using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution54
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            List<int> output = new List<int>();
            if(matrix.Length == 0)
            { return output; }
            SpiralSelected(matrix, 0, matrix.GetLength(0)-1, 0, matrix.GetLength(1)-1, output);

            return output;
        }

        private void SpiralSelected(int [,] matrix, int xLow, int xHigh, int yLow, int yHigh, List<int> output)
        {
            if(xLow ==xHigh || yLow == yHigh)
            {
                return;
            }

            bool stepOne = false;
            for(int i = xLow; i <= xHigh; i++)
            {
                stepOne = true;
                output.Add(matrix[i, yLow]);
            }

            if(stepOne)
            {
                yLow++;
            }

            bool stepTwo = false;
            for (int i = yLow; i <= yHigh; i++)
            {
                stepTwo = true;
                output.Add(matrix[xHigh, i]);
            }

            if (stepTwo)
            {
                xHigh--;
            }


            bool stepThree = false;
            for (int i = xHigh; i >= xLow; i--)
            {
                stepThree = true;
                output.Add(matrix[i, yHigh]);
            }

            if (stepThree)
            {
                yHigh--;
            }

            bool stepFour = false;
            for (int i = yHigh; i >= yLow; i--)
            {
                stepFour = true;
                output.Add(matrix[xLow, i]);
            }

            if (stepFour)
            {
                xLow++;
            }

            SpiralSelected(matrix, xLow, xHigh, yLow, yHigh, output);
        }
    }
}
