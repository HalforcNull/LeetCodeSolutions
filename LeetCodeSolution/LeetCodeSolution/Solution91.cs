using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution91
    {
        public int NumDecodings(string s)
        {
            if(s.Length == 0)
            { return 0; }

            return NumDecodingSub(s);


        }

        public int NumDecodingSub(string s)
        {
            if (s.Length == 0)
            { return 1; }

            if (s.Length == 2)
            {
                return TwoByteDecoding(s);
            }

            if (s.Length == 1)
            {
                return OneByteDecoding(s);
            }

            int middle = s.Length / 2;

            int DivideAfterMiddle = NumDecodingSub(s.Substring(0, middle + 1)) * NumDecodingSub(s.Substring(middle + 1, s.Length - middle - 1));
            int MiddleAndRightTogether = 0;
            if (TwoByteTogetherDecoding(s.Substring(middle, 2)) > 0)
            {
                MiddleAndRightTogether = NumDecodingSub(s.Substring(0, middle)) * NumDecodingSub(s.Substring(middle + 2, s.Length - middle - 2));
            }
            return DivideAfterMiddle + MiddleAndRightTogether;

        }

        public int TwoByteTogetherDecoding(string s)
        {
            int value = Convert.ToInt32(s);
            if (value < 10)
            { return 0; }

            if (value < 27)
            { return 1; }

            return 0;
        }

        public int TwoByteDecoding(string s)
        {
            int value = Convert.ToInt32(s);
            if(value < 10) 
            { return 0; }

            if( value == 10 || value == 20)
            { return 1; }

            if(value < 27 )
            { return 2; }

            if(value %10 == 0)
            {
                return 0;
            }

            return 1;
        }

        public int OneByteDecoding(string s)
        {
            if(s[0] == '0')
            { return 0; }

            return 1;
        }
    }
}
