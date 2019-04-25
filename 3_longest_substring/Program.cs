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
            int res = new Solution().LengthOfLongestSubstring("pwwkew");
            Console.WriteLine(res);
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int i = 0, l = s.Length, j = 0;

            List<int> res = new List<int>();

            List<char> lstCurrent = new List<char>();

            char tmp = char.MinValue;

            for (; i < l; i++)
            {
                tmp = s[i];
                if (lstCurrent.Contains(tmp))
                {
                    res.Add(lstCurrent.Count);
                    lstCurrent.Clear();
                    i = j++;
                }
                else
                {
                    lstCurrent.Add(tmp);
                }
            }
            res.Add(lstCurrent.Count);


            return res.Max();
        }
    }
}
