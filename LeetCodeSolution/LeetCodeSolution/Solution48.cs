using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution48
    {

        public void Rotate(int[,] matrix)
        {
            StartRotateBeginWithEachPointInTopLeftZone(matrix);

            if(matrix.GetLength(0) % 2 == 1)
            {
                //contains "two middle lines ( 1 vertical 1 horizon )"
                StartRotateBeginWithEachPointInLeftHalfHorizontialMiddleLine(matrix);
            }

            return;
        }

        /// <summary>
        /// Based on the points in first half of the Horizontial Middle Line
        /// Call rotateFourRelatedPoint function
        /// So all points in the middle lines would be rotated
        /// </summary>
        /// <param name="matrix"></param>
        private void StartRotateBeginWithEachPointInLeftHalfHorizontialMiddleLine(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int i = n / 2;
            for (int j = 0; j < n / 2; j++)
            {
                RotateFourRelatedPoint(matrix, i, j);
            }
        }

        /// <summary>
        /// Based on the points in TopLeftZone
        /// Call rotateFourRelatedPoint function
        /// So all points not in the middle lines would be rotated
        /// </summary>
        /// <param name="matrix"></param>
        private void StartRotateBeginWithEachPointInTopLeftZone(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for(int i = 0; i < n/2; i++)
            {
                for(int j = 0; j < n/2; j++)
                {
                    RotateFourRelatedPoint(matrix, i, j);
                }
            }
        }

        /// <summary>
        /// Rotate Four related points together based on given position
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private void RotateFourRelatedPoint(int[,] matrix, int row, int col)
        {
            int n = matrix.GetLength(0) - 1;

            int row2 = col;
            int col2 = n - row;

            int row3 = n - row;
            int col3 = n - col;

            int row4 = n - row2;
            int col4 = n - col2;

            int tempValue4 = matrix[row4, col4];
            matrix[row4, col4] = matrix[row3, col3];
            matrix[row3, col3] = matrix[row2, col2];
            matrix[row2, col2] = matrix[row, col];
            matrix[row, col] = tempValue4;

            return;
        }
    }
}
