using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution73
    {
        /// <summary>
        /// two solution:
        /// 
        /// I:
        ///     1. call check next point(t)
        ///     2. check next point(t)
        ///        if t is 0, set all lft point to 0 and all top to 0
        ///         check next point(t.next)
        ///        set all points in right to 0 and all belows to 0
        ///        return
        ///        
        /// II:
        ///     1. save all zeros points
        ///     2. change the value to 0
        ///     
        /// pickup solution II
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes(int[,] matrix)
        {
            bool[] wipeI = new bool[matrix.GetLength(0)];
            bool[] wipeJ = new bool[matrix.GetLength(1)];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j =0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == 0)
                    {
                        wipeI[i] = true;
                        wipeJ[j] = true;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(wipeI[i] || wipeJ[j])
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return;
        }
        
    }
}
