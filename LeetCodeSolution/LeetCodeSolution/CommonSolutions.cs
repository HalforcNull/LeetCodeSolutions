using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class CommonSolutions
    {
        #region K Sum
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sums"></param>
        /// <param name="total"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<IList<int>> KSum(int[] nums, int total, int k)
        {
            QuickSortWithRandomPivot(ref nums, 0, nums.Length -1 );

            return KSumSub(ref nums, 0, total, k);
        }

        private IList<IList<int>> KSumSub(ref int[] nums, int start, int total, int k)
        {
            
            if (k == 2)
            {
                return TwoSumSub(ref nums, start, total);
            }

            List<IList<int>> result = new List<IList<int>>();

            int temp = nums[start];
            IList<IList<int>> subresult = KSumSub(ref nums, start + 1, total - temp, k - 1);
            subresult.ToList().ForEach(t => { t.Add(temp); result.Add(t); } );
            
            for(int i = start+1; i < nums.Length; i++)
            {
                if(nums[i] == temp)
                { continue; }

                temp = nums[i];
                subresult = KSumSub(ref nums, i + 1, total - temp, k - 1);
                subresult.ToList().ForEach(t => { t.Add(temp); result.Add(t); });
            }

            return result;
            
        }

        private IList<IList<int>> TwoSumSub(ref int[] nums, int start, int total)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<int, int> resultHash = new Dictionary<int, int>();
            int i = start;
            int j = nums.Length - 1;
            while(i < j)
            {
                int sum = nums[i] + nums[j];
                if(sum == total)
                {
                    if(!resultHash.ContainsKey(nums[i]) )
                    { resultHash.Add(nums[i], nums[j]); }
                    i++;
                    j--;
                }
                else if( sum< total)
                { i++; }
                else
                { j--; }
            }

            foreach(KeyValuePair<int,int> r in resultHash)
            {
                List<int> t = new List<int>();
                t.Add(r.Key);
                t.Add(r.Value);

                result.Add(t);
            }

            return result;
        }
        #endregion

        #region Quick Sort
        public void QuickSortWithRandomPivot(ref int[] nums, int start, int end)
        {

            if(start >= end)
            { return; }
            int length = end - start + 1;

            Random r = new Random();
            int pIndex = r.Next(length);

            int NewPIndex = Partition(ref nums, start, end, pIndex);
            QuickSortWithRandomPivot(ref nums, start, NewPIndex - 1);
            QuickSortWithRandomPivot(ref nums, NewPIndex + 1, end);

        }

        private int Partition(ref int[] nums, int start, int end, int pivotIndex)
        {
            int pValue = nums[pivotIndex];

            int temp = nums[end];
            nums[end] = nums[start];
            nums[start] = temp;

            int storeIndex = start;
            for(int i = start; i < end; i++)
            {
                if(nums[i] <= pValue)
                {
                    temp = nums[i];
                    nums[i] = nums[storeIndex];
                    nums[storeIndex] = temp;

                    storeIndex++;
                }
            }

            temp = nums[end];
            nums[end] = nums[storeIndex];
            nums[storeIndex] = temp;

            return storeIndex;
        }
        #endregion

        #region Permutations
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (nums.Length == 1)
            {
                List<int> r = new List<int>();
                r.Add(nums[0]);
                result.Add(r);
                return result;
            }

            foreach (int n in nums)
            {
                List<int> newList = nums.ToList();
                newList.Remove(n);
                IList<IList<int>> currentResult = Permute(newList.ToArray());

                foreach(IList<int> r in currentResult)
                {
                    r.Insert(0, n);
                    result.Add(r);
                }
            }

            return result;
        }

        #endregion
    }
}
