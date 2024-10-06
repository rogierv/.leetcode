/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */

// @lc code=start
using System.Collections.Generic;

public class Solution383 {
    public bool CanConstruct(string ransomNote, string magazine) {
        var dict = BuildDict(magazine);
        foreach (var c in ransomNote.ToCharArray())
        {
            if (!dict.TryGetValue(c, out int value) || value == 0)
            {
                return false;
            }
            dict[c] = --value;
        }
        return true;
    }

    static Dictionary<char, int> BuildDict(string word) {
        Dictionary<char, int> dict = [];
        foreach (var c in word.ToCharArray())
        {
            if (dict.TryGetValue(c, out int value))
            {            
                dict[c] = ++value;
            } else {
                
                dict[c] = 1;
            }
        }
        return dict;
    }
}
// @lc code=end

