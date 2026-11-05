using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy.PalindromNumber
{
    public class Solve
    {
        public static void Run()
        {
            //Example 1:
            //Input: x = 121
            //Output: true
            //Explanation: 121 reads as 121 from left to right and from right to left.

            //Example 2:
            //Input: x = -121
            //Output: false
            //Explanation: From left to right, it reads - 121.From right to left, it becomes 121 -.Therefore it is not a palindrome.

            //Example 3:
            //Input: x = 10
            //Output: false
            //Explanation: Reads 01 from right to left.Therefore it is not a palindrome.


            if (isPalindrome(10))
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
        }

        private static bool isPalindrome(int x)
        {
            if (x < 0) return false;
            if (x < 10) return true;

            int divisor = 1;
            while (x / divisor > 9)
            {
                divisor *= 10;
            }

            while (divisor >= 10)
            {
                int leftDigit = x / divisor;
                int rightDigit = x % 10;

                if (leftDigit != rightDigit) return false;

                x = (x % divisor) / 10;

                divisor /= 100;
            }

            return true;
        }
    }
}
