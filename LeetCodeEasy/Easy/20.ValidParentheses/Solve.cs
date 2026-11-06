using System;
using System.Collections.Generic;

namespace LeetCode.Easy.ValidParentheses
{
    internal class Solve
    {
        public static void Run()
        {
            // Example 1:
            // Input: s = "()"
            // Output: true

            // Example 2:
            // Input: s = "()[]{}"
            // Output: true

            // Example 3:
            // Input: s = "(]"
            // Output: false

            // Example 4:
            // Input: s = "([])"
            // Output: true

            // Example 5:
            // Input: s = "([)]"
            // Output: false

            string check = "("; char test = char.Parse(check);

            bool isTrue = test == '(';


            string question1 = "(])";


            if (isValid(question1))
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
        }

        private static bool isValid(string s)
        {
            Stack<char> result = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if ("{([".Contains(s[i]))
                    result.Push(s[i]);
                else
                {
                    if (result.Count == 0) return false;

                    char checkerValue = result.Peek();

                    if ((checkerValue == '{' && s[i] == '}')
                    || (checkerValue == '(' && s[i] == ')')
                    || (checkerValue == '[' && s[i] == ']'))
                        result.Pop();
                    else
                        return false;
                }
            }

            return result.Count == 0;
        }

    }
}