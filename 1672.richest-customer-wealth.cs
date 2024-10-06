/*
 * @lc app=leetcode id=1672 lang=csharp
 *
 * [1672] Richest Customer Wealth
 */

// @lc code=start
using System.Linq;

public class Solution1672 {
    public int MaximumWealth(int[][] accounts) {

        return accounts.Select(x => x.Sum()).Max();
    }
}
// @lc code=end

