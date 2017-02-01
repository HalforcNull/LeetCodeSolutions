using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution20
    {
        /// <summary>
        /// classical question for stack
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            for(int i = 0; i < s.Length; i++)
            {
                switch(s[i])
                {
                    case '(':
                    case '[':
                    case '{':
                        st.Push(s[i]);
                        continue;
                    case ')':
                        if(st.Count == 0 || st.Pop() != '(')
                        { return false; }
                        continue;
                    case ']':
                        if (st.Count == 0 || st.Pop() != '[')
                        { return false; }
                        continue;
                    case '}':
                        if (st.Count == 0 || st.Pop() != '{')
                        { return false; }
                        continue;
                    default:
                        return false;
                }
            }

            if(st.Count != 0)
            { return false; }
            else
            { return true; }
        }
        
    }
}
