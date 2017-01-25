using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution30
    {
        public IList<int> FindSubstring(string s, string[] words)
        {

            List<int> workableHeader = new List<int>();
            List<int> result = new List<int>();

            int dictionarySize = words.Length * words[0].Length;

            if(dictionarySize > s.Length)
            {
                return result;
            }

            int[] wordCharCount = getStringCharCount(string.Join("", words));
            int[] currentCharCount = getStringCharCount(s.Substring(0, dictionarySize));

            if (isCharCountTheSame(wordCharCount, currentCharCount))
            {
                workableHeader.Add(0);
            }

            for (int i = 0; i < s.Length - dictionarySize; i++)
            {
                char outC = s[i];
                char inC = s[i + dictionarySize];
                currentCharCount[outC]--;
                currentCharCount[inC]++;
           
                if (isCharCountTheSame(wordCharCount, currentCharCount))
                {
                    workableHeader.Add(i+1);
                }
            }

            Dictionary<string, int> wordStatus = calculateWordFrenq(words);

            foreach (int header in workableHeader)
            {
                if(isConcatenation(s.Substring(header,dictionarySize), wordStatus, words[0].Length, dictionarySize))
                {
                    result.Add(header);
                }
            }

            return result;
        }

        private Dictionary<string, int> calculateWordFrenq(string[] words)
        {
            Dictionary<string, int> wordF = new Dictionary<string, int>();
            foreach(string s in words)
            {
                if(wordF.ContainsKey(s))
                {
                    wordF[s]++;
                }
                else
                {
                    wordF[s] = 1;
                }
            }

            return wordF;
        }

        private bool isConcatenation(string s, Dictionary<string,int> wordStatus, int wordSize, int dictionarySize)
        {

            Dictionary<string, int> wordStatusCopy = new Dictionary<string, int>();

            foreach(string key in wordStatus.Keys)
            {
                wordStatusCopy.Add(key, wordStatus[key]);
            }

            for (int i = 0; i < s.Length / wordSize; i++)
            {
                string sub = s.Substring(i* wordSize, wordSize);
                if (!wordStatusCopy.ContainsKey(sub))
                {
                    return false;
                }
                wordStatusCopy[sub]--;
                if(wordStatusCopy[sub] < 0)
                { return false; }
            }

            return true;
        }

        private int[] getStringCharCount(string s)
        {
            int[] result = new int[128];
            foreach (char c in s)
            {
                result[c]++;
            }

            return result;
        }

        private bool isCharCountTheSame(int[] a, int[] b)
        {
            for (int i = 65; i < 91; i++)
            {
                if(a[i] != b[i])
                { return false; }
            }

            for (int i = 97; i < 122; i++)
            {
                if (a[i] != b[i])
                { return false; }
            }

            return true;
        }
    }
}
