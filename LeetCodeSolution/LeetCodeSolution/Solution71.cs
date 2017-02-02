using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution71
    {
        /*
         / -> root
        /a -> in (a)
        . -> THIS dir path 
        /a/./ -> still in /a
        /a/./b -> in /a/b
        .. -> go "up" one level
        */


        public string SimplifyPath(string path)
        {
            string result = "";
            Stack<string> pathes = new Stack<string>();
            string[] commands = path.Split("/".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in commands)
            {
                if(s.Length == 1 && s[0] == '.')
                {
                    continue;
                }

                if(s.Length == 2&& s[0] == '.' && s[1] == '.' )
                {
                    if (pathes.Count > 0)
                    { pathes.Pop(); }
                    continue;
                }

                pathes.Push(s);
            }

            while(pathes.Count > 0)
            {
                result = "/" + pathes.Pop() +  result;
            }

            if(result.Length==0)
            {
                result = "/";
            }

            return result;
        }
    }
}
