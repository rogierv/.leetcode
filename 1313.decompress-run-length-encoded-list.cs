/*
 * @lc app=leetcode id=1313 lang=csharp
 *
 * [1313] Decompress Run-Length Encoded List
 */

// @lc code=start
using System.Collections.Generic;

public class Solution1313 {
    public int[] DecompressRLElist(int[] nums) {
        List<int> result = [];
        for (int i = 0; i < nums.Length; i += 2)
        {
            for (int j = 0; j < nums[i]; j++)
            {
                result.Add(nums[i+1]);
            }
        }
        return [.. result];
    }
} 
// @lc code=end

