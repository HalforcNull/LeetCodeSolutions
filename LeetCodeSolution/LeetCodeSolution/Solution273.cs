using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution273
    {
        public string NumberToWords(int num)
        {
            if(num == 0)
            { return "Zero"; }
            
            string output = "";
            string Billion = GetLessThanThousanExp(num / 1000000000);
            string Million = GetLessThanThousanExp(num % 1000000000 / 1000000);
            string Thousand = GetLessThanThousanExp(num % 1000000 / 1000);
            string Rest = GetLessThanThousanExp(num % 1000);


            if (!String.IsNullOrWhiteSpace(Billion))
            { Billion += " Billion"; }

            if (!String.IsNullOrWhiteSpace(Million))
            { Million += " Million"; }

            if (!String.IsNullOrWhiteSpace(Thousand))
            { Thousand += " Thousand"; }

            output = Billion;

            if(!String.IsNullOrWhiteSpace(output) && !String.IsNullOrWhiteSpace(Million))
            {
                output += " " + Million;
            }
            else
            {
                output += Million;
            }

            if (!String.IsNullOrWhiteSpace(output) && !String.IsNullOrWhiteSpace(Thousand))
            {
                output += " " + Thousand;
            }
            else
            {
                output += Thousand;
            }

            if (!String.IsNullOrWhiteSpace(output) && !String.IsNullOrWhiteSpace(Rest))
            {
                output += " " + Rest;
            }
            else
            {
                output += Rest;
            }

            return output;
        }

        private string GetLessThanThousanExp(int num)
        {
            string exp = "";
            int hundred = num / 100;

            int rest = num % 100;

            if (hundred > 0)
            {
                exp += DigitToEnglish(hundred) + " Hundred";
                if (rest == 0)
                {
                    return exp;
                }
                else
                {
                    exp += " ";
                }
            }

            
            if (rest < 10)
            {
                exp += DigitToEnglish(rest);
                return exp;
            }

            if (rest < 20)
            {
                exp += TenToNineteenToEnglish(rest);
                return exp;
            }

            string lastbit = DigitToEnglish(rest % 10);
            exp += TensToEnglish(rest / 10);
            if (!String.IsNullOrWhiteSpace(lastbit))
            {
                exp += " " + lastbit;
            }
            return exp;
        }

        private string DigitToEnglish(int num)
        {
            if (num == 0)
            {
                return "";
            }


            switch (num)
            {
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                default:
                    return "";
            }
        }

        private string TensToEnglish(int num)
        {
            if (num < 2)
            {
                return "";
            }

            switch (num)
            {
                case 2:
                    return "Twenty";
                case 3:
                    return "Thirty";
                case 4:
                    return "Forty";
                case 5:
                    return "Fifty";
                case 6:
                    return "Sixty";
                case 7:
                    return "Seventy";
                case 8:
                    return "Eighty";
                case 9:
                    return "Ninety";
                default:
                    return "";
            }
        }

        private string TenToNineteenToEnglish(int num)
        {
            if (num > 19 || num < 10)
            {
                return "";
            }

            switch (num)
            {
                case 10:
                    return "Ten";
                case 11:
                    return "Eleven";
                case 12:
                    return "Twelve";
                case 13:
                    return "Thirteen";
                case 14:
                    return "Fourteen";
                case 15:
                    return "Fifteen";
                case 16:
                    return "Sixteen";
                case 17:
                    return "Seventeen";
                case 18:
                    return "Eighteen";
                case 19:
                    return "Nineteen";
                default:
                    return "";
            }
        }
    }
}
