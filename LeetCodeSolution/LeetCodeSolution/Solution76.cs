using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{

    //public class Solution76
    //{
    //    public string MinWindow(string s, string t)
    //    {
    //        Dictionary<char, int> currentBest = null;
    //        Dictionary<char, int> buildingNewBest = new Dictionary<char, int>();


    //    }
    //}

    //public class Answer
    //{
    //    Dictionary<char, int> positionRecorder;
    //    List<char> charRecorder;
        
    //    public Answer(string t)
    //    {
    //        positionRecorder = new Dictionary<char, int>();
    //        charRecorder = new List<char>();
    //        foreach(char c in t)
    //        {
    //            positionRecorder.Add(c, -1);
    //        }
    //    }

    //    public bool creatingNewAnswer(char c, int position)
    //    {
    //        if(positionRecorder[c] < 0)
    //        {
    //            insertNewChar(c, position);
    //            return haveAllChar();
    //        }
    //        else if()
    //        {
    //            replaceExistingChar(c, position);
    //            return haveAllChar();
    //        }

            
    //    }

    //    private bool haveAllChar()
    //    {
    //        foreach(KeyValuePair<char,int> t in positionRecorder)
    //        {
    //            if(t.Value < 0)
    //            { return false; }
    //        }
    //        return true;
    //    }

    //    private void insertNewChar(char c, int position)
    //    {
    //        positionRecorder.Add(c, position);
    //        charRecorder.Add(c);
    //    }

    //    private void replaceExistingChar(char c, int position)
    //    {
    //        positionRecorder[c] = position;
    //        charRecorder.Remove(c);
    //        charRecorder.Add(c);
    //    }

    //    private void shouldReplace(char c, int position)
    //    {
    //        if()

    //        int currentFirstIndex = positionRecorder[charRecorder[0]];
    //    }

    //    public int GetLength()
    //    {
    //        int max = 0;
    //        int min = 0;
    //        foreach(KeyValuePair<char,int> t in positionRecorder)
    //        {
    //                if(t.Value < 0)
    //                {
    //                    return -1;
    //                }

    //                if(t.Value > max)
    //                {
    //                    max = t.Value;
    //                }

    //                if(t.Value < min)
    //                {
    //                    min = t.Value;
    //                }
    //            }
    //            return max - min + 1;
    //    }


    //}
}
