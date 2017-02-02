using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution208
    {

        /**
         * Your Trie object will be instantiated and called as such:
         * Trie obj = new Trie();
         * obj.Insert(word);
         * bool param_2 = obj.Search(word);
         * bool param_3 = obj.StartsWith(prefix);
         */
    }

    public class Trie
    {
        Trie[] Sons;
        bool isWord;
        /** Initialize your data structure here. */
        public Trie()
        {
            Sons = new Trie[26];
            isWord = false;
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            int index = (int)word[0] - (int)'a';
            if(Sons[index] == null)
            {
                Sons[index] = new Trie();
            }

            if (word.Length > 1)
            {
                Sons[index].Insert(word.Substring(1));
            }
            else
            {
                Sons[index].isWord = true;
            }
            return;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            if(word.Length == 0)
            {
                return isWord;
            }

            int index = (int)word[0] - (int)'a';
            if (Sons[index] == null)
            {
                return false;
            }

            return Sons[index].Search(word.Substring(1));
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            if(prefix.Length == 0)
            {
                return Sons.Any(t => t != null) || isWord;
            }

            int index = (int)prefix[0] - (int)'a';
            if (Sons[index] == null)
            {
                return false;
            }

            return Sons[index].StartsWith(prefix.Substring(1));
        }
    }
}
