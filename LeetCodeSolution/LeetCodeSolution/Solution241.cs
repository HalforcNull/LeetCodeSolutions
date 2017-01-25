using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution241
    {
        enum Operations { Add, Cut, Mult }
        public IList<int> DiffWaysToCompute(string input)
        {
            string[] rawparms;
            string[] rawoperations;

            parse(input, out rawparms, out rawoperations);

            List<int> result = new List<int>();

            PermResult(convertParm(rawparms), convertOps(rawoperations), result);

            return result;
        }

        private void parse(string input, out string[] parm, out string[] operation)
        {
            char[] operations = { '+', '-', '*' };
            char[] digit = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            string nonSpaceInput = input.Replace(" ", String.Empty);

            parm = nonSpaceInput.Split(operations, StringSplitOptions.RemoveEmptyEntries);
            operation = nonSpaceInput.Split(digit, StringSplitOptions.RemoveEmptyEntries);

            return;
        }

        private List<int> convertParm(string[] parm)
        {
            List<int> result = new List<int>();
            foreach (string s in parm)
            {
                result.Add(Convert.ToInt32(s));
            }

            return result;
        }

        private List<Operations> convertOps(string[] operation)
        {
            List<Operations> result = new List<Operations>();
            foreach (string s in operation)
            {
                switch (s)
                {
                    case "+":
                        result.Add(Operations.Add);
                        break;
                    case "-":
                        result.Add(Operations.Cut);
                        break;
                    case "*":
                        result.Add(Operations.Mult);
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        private void PermResult(List<int> parm, List<Operations> operation, List<int> result)
        {
            if (operation.Count == 0)
            {
                result.Add(parm[0]);
            }

            for (int i = 0; i < operation.Count; i++)
            {
                List<int> newParm;
                List<Operations> newOps;
                DoCalculation(parm, operation, i, out newParm, out newOps);
                PermResult(newParm, newOps, result);
            }
        }

        private void DoCalculation(List<int> parm, List<Operations> operation, int index, out List<int> resultParm, out List<Operations> resultOps)
        {
            resultParm = new List<int>();
            resultOps = new List<Operations>();

            int j = 0;

            for (int i = 0; i < operation.Count; i++)
            {
                if (i != index)
                {
                    resultParm.Add(parm[i + j]);
                    resultOps.Add(operation[i]);
                    continue;
                }

                switch (operation[i])
                {
                    case Operations.Add:
                        resultParm.Add(parm[i] + parm[i + 1]);
                        break;
                    case Operations.Cut:
                        resultParm.Add(parm[i] - parm[i + 1]);
                        break;
                    case Operations.Mult:
                        resultParm.Add(parm[i] * parm[i + 1]);
                        break;
                    default:
                        break;
                }

                j = 1;
            }

            return;
        }
    }

    /*
     * 
        private void getPerm(int[] header, int[] tail, List<int[]> output )
        {
            if (tail.Length == 0)
            {
                output.Add(header);
                return;
            }
            

            foreach( int num in tail)
            {
                List<int> newHeader = header.ToList();
                List<int> newTail = tail.ToList();
                newHeader.Add(num);
                newTail.Remove(num);

                getPerm(newHeader.ToArray(), newTail.ToArray(), output);
            }
        }

        private int[] getInitArray(int max)
        {
            List<int> result = new List<int>();
            for(int i = 0; i < max; i++)
            {
                result.Add(i);
            }

            return result.ToArray();
        }

    */



}
