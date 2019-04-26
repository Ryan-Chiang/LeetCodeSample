using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_median_of_two_sorted_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = new Solution().FindMedianSortedArrays(new int[] {1,2 }, new int[] { 3,4 });
            Console.WriteLine(res);
        }
    }

    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            int l1 = nums1.Length, l2 = nums2.Length, lr = l1 + l2, r = 0, i = 0, j = 0, idxMid = lr / 2;
            int[] res = new int[lr];
            if (nums1.Length == 0)
            {
                res = nums2;
            }
            else if (nums2.Length == 0)
            {
                res = nums1;
            }
            else
            {
                int tmp1 = nums1[i], tmp2 = nums2[j];
                for (; r < lr; r++)
                {
                    if (tmp1 < tmp2)
                    {
                        res[r] = tmp1;
                        if (i < l1 - 1)
                        {
                            i++;
                            tmp1 = nums1[i];
                        }
                        else
                        {
                            tmp1 = int.MaxValue; 
                        }
                    }
                    else
                    {
                        res[r] = tmp2;
                        if (j < l2 - 1)
                        {
                            j++;
                            tmp2 = nums2[j];
                        }
                        else
                        {
                            tmp2 = int.MaxValue;
                        }
                    }
                }
            }
            if(lr % 2 == 0)
            {
                return (((double)res[idxMid - 1] + res[idxMid]) / 2);
            }
            return res[idxMid];

            //List<int> lstRes = new List<int>();
            //lstRes.AddRange(nums1);
            //lstRes.AddRange(nums2);
            //lstRes.Sort();
            //int mid = lstRes.Count / 2;
            //if (lstRes.Count % 2 == 0)
            //{
            //    return (double)(lstRes[mid - 1] + lstRes[mid]) / 2;
            //}
            //return lstRes[mid];
        }
    }
}
