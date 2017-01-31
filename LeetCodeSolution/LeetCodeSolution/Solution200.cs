using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution200
    {
        public int NumIslands(char[,] grid)
        {
            int count = 0;
            for(int i = 0; i < grid.GetLength(0); i++)
            {
                for(int j = 0; j < grid.GetLength(1); j++)
                {
                    if(grid[i,j] == '1')
                    {
                        count++;
                        HoldIsland(grid, i, j);
                    }
                }
            }

            return count;
        }

        private void HoldIsland(char[,] grid, int x, int y)
        {
            grid[x, y] = 'X';

            if(x>0&&grid[x-1, y] == '1')
            {
                //up
                HoldIsland(grid, x - 1, y);
            }

            if(x+1 < grid.GetLength(0)  && grid[x+1,y] == '1')
            {
                //down
                HoldIsland(grid, x + 1, y);
            }

            if(y>0&&grid[x,y-1] == '1')
            {
                //left
                HoldIsland(grid, x, y - 1);
            }

            if(y+1 < grid.GetLength(1) && grid[x,y+1] =='1')
            {
                //right
                HoldIsland(grid, x, y + 1);
            }
        }
    }
}
