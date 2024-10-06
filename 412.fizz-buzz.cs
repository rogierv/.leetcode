/*
 * @lc app=leetcode id=412 lang=csharp
 *
 * [412] Fizz Buzz
 */

// @lc code=start
using System.Collections.Generic;
using System.Linq;

public class Solution412 {
    public IList<string> FizzBuzz(int n) => Enumerable
            .Range(1,n)
            .Select(GetFizzBuzz)
            .ToList();

    private string GetFizzBuzz(int n) => n switch
        {
            var x when x % 3 == 0 && x % 5 == 0 => "FizzBuzz",
            var x when x % 3 == 0               => "Fizz",
            var x when x % 5 == 0               => "Buzz",
            _                                   => n.ToString()
        };
}
// @lc code=end

