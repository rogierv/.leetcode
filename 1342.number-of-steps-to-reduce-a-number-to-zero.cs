/*
 * @lc app=leetcode id=1342 lang=csharp
 *
 * [1342] Number of Steps to Reduce a Number to Zero
 */

// @lc code=start
public class Solution1342 {
    public int NumberOfSteps(int num) {
        var count = 0;
        while (num != 0)
        {
            if (num % 2 == 0)
            {
                num /= 2;
            } 
            else 
            {
                num--;
            }
            count++;
        }
        return count;
    }
}
// @lc code=end

