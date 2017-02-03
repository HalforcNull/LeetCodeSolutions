using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution79
    {
        public bool Exist(char[,] board, string word)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    bool[][] path = new bool[board.GetLength(0)][];
                    for(int k = 0; k < board.GetLength(0); k++)
                    {
                        path[k] = new bool[board.GetLength(1)];
                    }

                    if (IsExistStartWith(board, path, i, j, word))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsExistStartWith(char[,] board, bool[][] path, int i, int j, string word)
        {
            if(word.Length == 0)
            {
                return true;
            }

            if ( i < 0 || j < 0
                || board.GetLength(0) <= i || board.GetLength(1) <= j
                || path[i][j]
                || word[0] != board[i, j])
            {
                return false;
            }
            path[i][j] = true;

            return IsExistStartWith(board, path.Select(t => t.ToArray()).ToArray(), i + 1, j, word.Substring(1))
                || IsExistStartWith(board, path.Select(t => t.ToArray()).ToArray(), i - 1, j, word.Substring(1))
                || IsExistStartWith(board, path.Select(t => t.ToArray()).ToArray(), i, j + 1, word.Substring(1))
                || IsExistStartWith(board, path.Select(t => t.ToArray()).ToArray(), i, j - 1, word.Substring(1));
        }
    }
}
