using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution419
    {
        public int CountBattleships(char[,] board)
        {
            int OnePointBattleship = 0;
            int HeaderorTail = 0;

            for(int i = 0;i< board.GetLength(0);i++)
            {
                for(int j = 0; j < board.GetLength(1);j++)
                {
                    if(board[i,j] == '.')
                    {
                        continue;
                    }
                    int adjacent = CountAdjacent(board, i, j);
                    if (adjacent == 0)
                    {
                        OnePointBattleship++;
                        continue;
                    }

                    if(adjacent == 1)
                    {
                        HeaderorTail++;
                        continue;
                    }
                }
            }

            return OnePointBattleship + HeaderorTail / 2;
        }

        public int CountAdjacent(char[,] board, int x, int y)
        {
            int output = 0;
            if(x + 1 != board.GetLength(0) && board[x + 1, y] == 'X')
            {
                //check right hand
                output++; 
            }

            if(x != 0 && board[x-1,y] == 'X')
            {
                //check left hand
                output++;
            }

            if(y+1 != board.GetLength(1) && board[x, y+1] == 'X')
            {
                //check point under
                output++;
            }

            if(y!= 0&& board[x,y-1] == 'X')
            {
                //check point above
                output++;
            }
            return output;
        }
    }
}
