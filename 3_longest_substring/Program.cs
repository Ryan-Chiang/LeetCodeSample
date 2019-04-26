using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3_longest_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = new Solution().LengthOfLongestSubstring(" ");
            Console.WriteLine(res);
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(s.Length == 0)
            {
                return 0;
            }

            int i = 0, l = s.Length, j = 0, res = 0, subLength = 0;
            List<char> lstCurrent = new List<char>();
            char tmp = char.MinValue;

            for (; i < l; i++)
            {
                tmp = s[i];
                subLength = lstCurrent.Count;
                if (lstCurrent.Contains(tmp))
                {
                    res = subLength > res ? subLength : res;
                    lstCurrent.Clear();
                    i = j++;

                }
                else
                {
                    lstCurrent.Add(tmp);
                }
            }
            subLength = lstCurrent.Count;
            res = subLength > res ? subLength : res;
            return res;
        }
    }
}
