using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows < 2)
            {
                return s;
            }



            string OutputStr = "";


            List<int> firstRowIndex = getFirstLine(s.Length, numRows);
            
            foreach (int i in firstRowIndex)
            {
                if(i < s.Length)
                {
                    OutputStr += s[i];
                }
            }

            for (int rowIndex = 1; rowIndex < numRows - 1; rowIndex++)
            {
                List<int> middleRowIndex = getMiddleLine(firstRowIndex, rowIndex, s.Length);
                foreach(int i in middleRowIndex)
                {
                    if (i < s.Length)
                    {
                        OutputStr += s[i];
                    }
                }
            }



            List<int> lastRowIndex = getLastLine(s.Length, numRows);

            foreach (int i in lastRowIndex)
            {
                if (i < s.Length)
                {
                    OutputStr += s[i];
                }
            }

            return OutputStr;
        }

        private int firstLineDistance(int numRows)
        {
            return numRows * 2 - 2;
        }

        private List<int> getMiddleLine(List<int> firstLine, int lineNum, int length)
        {
            List<int> returnList = new List<int>();
            returnList.Add(lineNum);
            for (int i = 1; i < firstLine.Count; i++)
            {
                returnList.Add(firstLine[i] - lineNum);
                returnList.Add(firstLine[i] + lineNum);
            }

            return returnList;
        }

        private List<int> getFirstLine(int length, int numRows)
        {
            List<int> returnList = new List<int>();
            int distance = firstLineDistance(numRows);
            int index = 0;
            for (int i = 0; i < length/numRows+1; i++ )
            {
                returnList.Add(index);
                index += distance;
            }
            
            return returnList;
        }


        private List<int> getLastLine(int length, int numRows)
        {
            List<int> returnList = new List<int>();
            int distance = firstLineDistance(numRows);
            int index = numRows-1;
            for (int i = 0; i < length / numRows; i++)
            {
                returnList.Add(index);
                index += distance;
            }
            
            return returnList;
        }
    }
}
