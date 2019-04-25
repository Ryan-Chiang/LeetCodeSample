using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_longest_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = new Solution().LengthOfLongestSubstring("alkjd");
            Console.WriteLine(res);
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int i = 0, l = s.Length, j = 0;
            Dictionary<char[], int> dictContainer = new Dictionary<char[], int>();

            List<char> lstCurrent = new List<char>(l);

            char tmp = char.MinValue;

            for (; i < l; i++)
            {
                tmp = s[i];
                if (lstCurrent.Contains(tmp))
                {
                    dictContainer.Add(lstCurrent.ToArray(), lstCurrent.Count());
                    lstCurrent.Clear();
                    i = j++;
                }
                else
                {
                    lstCurrent.Add(tmp);
                }
            }
            dictContainer.Add(lstCurrent.ToArray(), lstCurrent.Count());

            return dictContainer.Values.Max();
        }
    }
}
