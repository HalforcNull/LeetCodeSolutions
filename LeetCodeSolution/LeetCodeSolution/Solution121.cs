using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution121
    {
        public int MaxProfit(int[] prices)
        {
            possibleSolution currentBest = null;
            possibleSolution buildingSolution = null;

            for (int i = 0; i < prices.Length; i++)
            {
                findAnyNewBetterSolutionBeatCurrentBest(ref buildingSolution, ref currentBest, prices[i], i);
            }

            if(currentBest == null)
            {
                currentBest = buildingSolution;
            }
            
            if(buildingSolution!= null && buildingSolution.GetProfit() > currentBest.GetProfit())
            {
                currentBest = buildingSolution;
            }

            if (currentBest == null || currentBest.GetProfit() < 0)
            {
                return 0;
            }

            return currentBest.GetProfit();
        }

        private void findAnyNewBetterSolutionBeatCurrentBest(ref possibleSolution buildingSolution, ref possibleSolution currentBest, int v, int i)
        {
            if (buildingSolution == null)
            {
                buildingSolution = new possibleSolution();
            }

            if (!buildingSolution.hasBuyPrice)
            {
                //no buy price, use current one;
                buildingSolution.setBuyPrice(v, i);
                return;
            }

            if (buildingSolution.LowP > v)
            {
                if (buildingSolution.hasSellPrice)
                {
                    //has both buy and sell
                    //check profit with best one
                    if (currentBest == null || currentBest.GetProfit() < buildingSolution.GetProfit())
                    {
                        //if is better solution, replace exsiting one.
                        currentBest = buildingSolution;
                    }

                    //clean current building Solution, setup new one
                    buildingSolution = new possibleSolution();
                    buildingSolution.setBuyPrice(v, i);
                    return;
                }
                else
                {
                    //no buy price. simple set new price as sell price
                    buildingSolution.setBuyPrice(v, i);
                    return;
                }
            }

            if (!buildingSolution.hasSellPrice || buildingSolution.HighP < v)
            {
                buildingSolution.setSellPrice(v, i);
                return;
            }
        }
    }



    public class possibleSolution
    {
        public int LowP { get; private set; }
        public int LowI { get; private set; }

        public int HighP { get; private set; }
        public int HighI { get; private set; }

        public int GetProfit()
        {
            if (LowI < 0 || HighI < 0)
            { return -1; }

            return HighP - LowP;
        }

        public possibleSolution()
        {
            LowI = -1;
            HighI = -1;
        }

        public bool hasBuyPrice { get { return LowI >= 0; } }
        public bool hasSellPrice { get { return HighI >= 0; } }

        public void setBuyPrice(int p, int i)
        {
            LowP = p;
            LowI = i;
        }

        public void setSellPrice(int p, int i)
        {
            if (LowI < 0)
            {
                return;
            }

            HighP = p;
            HighI = i;
        }
    }
}
