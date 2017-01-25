using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution216
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            if(k >=n || k*10 <n)
            {
                return new List<IList<int>>();
            }

            return GetAllPossibleCombinationSum(k, n, 1);
        }

        private List<IList<int>> GetAllPossibleCombinationSum(int k, int n, int minFact)
        {
            List<IList<int>> result = new List<IList<int>>();

            if (k == 1 && n >= minFact && n<10)
            {
                List<int> currentResult = new List<int>();
                currentResult.Add(n);
                result.Add(currentResult);

                return result;
            }

            if (k == 0 || n < minFact)
            {
                return result;
            }

            for (int i = minFact; i < 10; i++)
            {
                List<IList<int>> newResultList = new List<IList<int>>();
                newResultList = GetAllPossibleCombinationSum(k - 1, n - i, i + 1);
                foreach (List<int> list in newResultList)
                {
                    list.Add(i);
                    result.Add(list);
                }
            }
            return result;
        }
    }
}
