using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.RomanToInteger
{
    public class Solve
    {
        public static void Run()
        {
            // Example 1:
            // Input: s = "III"
            // Output: 3
            // Explanation: III = 3.

            // Example 2:
            // Input: s = "LVIII"
            // Output: 58
            // Explanation: L = 50, V = 5, III = 3.

            // Example 3:
            // Input: s = "MCMXCIV"
            // Output: 1994
            // Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.


            if (romanToInt("MCMXCIV") == 1994)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
        }

        private static int romanToInt(string s)
        {
            int result = 0;
            int prev = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int intRomanValue = s[i] switch
                {
                    'I' => 1,
                    'V' => 5,
                    'X' => 10,
                    'L' => 50,
                    'C' => 100,
                    'D' => 500,
                    'M' => 1000,
                    _ => 0
                };

                result += intRomanValue;
                if (intRomanValue > prev)
                    result -= prev * 2;

                prev = intRomanValue;
            }

            return result;
        }
    }
}
