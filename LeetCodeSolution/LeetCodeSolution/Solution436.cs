using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution436
    {
        public int[] FindRightInterval(Interval[] intervals)
        {
            
            List<int> result = new List<int>();

            if (intervals.Length == 0)
            { return result.ToArray(); }

            
            var sorted = intervals
                .Select((x, i) => new KeyValuePair<Interval, int>(x, i))
                .OrderBy(x => x.Key.start);

            List<Interval> sortedIntvl = sorted.Select(t => t.Key).ToList();
            List<int> index = sorted.Select(t => t.Value).ToList();
            
            foreach(Interval i in intervals)
            {
                int minRightSortedIndex = sortedIntvl.FindIndex(t => t.start >= i.end);
                if(minRightSortedIndex >= 0)
                {
                    result.Add(index[minRightSortedIndex]);
                }
                else
                {
                    result.Add(-1);
                }
            }
            return result.ToArray();
        }
    }

    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }

}
