using System;
using System.Collections.Generic;


namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static List<char> BracketList = new List<char>();

        public static char[] BracketsToBracketList(string str2)
        {
            char[] charArr = str2.ToCharArray();

            foreach (char ch in charArr)
            {
                if (ch == '[' || ch == ']')
                {
                    BracketList.Add(ch);
                }
            }
            return charArr;

        }
        public static int NumberBalance()
        {
            int brackets = 0;
            foreach (char bracket in BracketList)
            {
                if (bracket == '[')
                {
                    brackets++;
                }
                else if (bracket == ']')
                {
                    brackets--;
                }
            }
            return brackets;
        }

        public static bool HasBalancedBracketsNew(string str1)
        {
            bool success = false;
            BracketsToBracketList(str1);
            if (BracketList.Count % 2 == 0 && BracketList.IndexOf('[') < BracketList.IndexOf(']') && NumberBalance() == 0)
            {
                success = true;
            }
            //BracketList.Clear();

            return success;
        }
        public static bool HasBalancedBrackets(String str)
        {
            int brackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (brackets >= 0)
                {
                    if (ch == '[')
                    {
                        brackets++;
                    }
                    else if (ch == ']')
                    {
                        brackets--;
                    }
                }
                else
                {
                    return false;
                }
            }
            return brackets == 0;
        }

    }
}
