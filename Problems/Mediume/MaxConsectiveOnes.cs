using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCoding.Problems.Mediume
{
    /// <summary>
    /// maximum consective ones 
    /// https://leetcode.com/problems/max-consecutive-ones-iii
    /// </summary>
    public class MaxConsectiveOnes
    {
        public int LongestOnes(int[] a, int K)
        {
            var sIndex = 0;
            var max = 0;
            var count = 0;

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] == 0 && count == K)
                {
                    while (a[sIndex] == 1)
                    {
                        sIndex++;
                    }
                    sIndex++;
                }
                else if (a[i] == 0)
                {
                    count++;
                }
                max = Math.Max(max, i - sIndex + 1);

            }
            return max;

        }
    }
}
