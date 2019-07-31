// -----------------------------------------------------------------------------
//  <copyright file="TwoSum.cs" company="DCOM Engineering, LLC">
//      Copyright (c) DCOM Engineering, LLC.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------

namespace Algorithms
{
    using System.Collections.Generic;

    public class TwoSum
    {
        public static int[] BruteForce(int[] nums, int target)
        {
            var set = new Dictionary<int, int>();
        
            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i], i);
            }
        
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
            
                if (set.ContainsKey(complement)) {
                    int j = set[complement];
                
                    if (i != j)
                    {
                        return new int[2] { i, j };   
                    }
                }
            }
        
            return new int[0];
        }
    }
}