using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Find the max
    /// </summary>
    public class Operations
    {
        public static int Max(List<int> nums)
        {
        /// <summary>
        /// Function that finds the max integer in a list of integers
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <returns>Integer: the max integer</returns>
            if (nums.Count == 0)
                return 0;
            int max = 0;
            foreach (int i in nums)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }
    }
}
