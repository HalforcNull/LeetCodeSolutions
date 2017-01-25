using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution126
    {
        
        private List<List<int>> findAllShortesPath(int start, int end, List<int> possibleChoices, Dictionary<int, List<int>> relatedDictionary)
        {
            
        }

        private bool reachable(string s1, string s2)
        {
            bool hasDiff = false;
            for(int i = 0; i < s1.Length; i++ )
            {
                if (s1[i] != s2[i] && !hasDiff)
                {
                    hasDiff = true;
                    continue;
                }

                if (s1[i] != s2[i] && hasDiff)
                    return false;
            }
            return true;
        }

        private List<string> findAllReachableWords(string start, IList<string> dictionary)
        {
            List<string> output = new List<string>();
            foreach(string word in dictionary)
            {
                if(reachable(start,word))
                {
                    output.Add(word);
                }
            }

            return output;
        }

        private bool runNextlevel(List<WordTrack> currentTracks, ref List<int> possibleSelections, Dictionary<int, List<int>> relatedDictionary, string target)
        {
            List<int> usedSelections = new List<int>();
            foreach(WordTrack wt in currentTracks)
            {
                foreach(int selection in possibleSelections)
                {
                    if (relatedDictionary.ContainsKey(wt.currentWord) && relatedDictionary[wt.currentWord].Contains(selection))
                    {

                    }
                }
            }
        }
    }

    public class WordTrack
    {
        public int currentWord;
        public List<int> path = new List<int>();
    }
}
