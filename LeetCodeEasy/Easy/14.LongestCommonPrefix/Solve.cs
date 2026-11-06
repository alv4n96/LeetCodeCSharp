using System;
using System.Linq;

namespace LeetCode.Easy.LongestCommonPrefix
{
    internal class Solve
    {
        public static void Run()
        {
            //Example 1:
            //Input: strs = ["flower", "flow", "flight"]
            //Output: "fl"

            //Example 2:
            //Input: strs = ["dog", "racecar", "car"]
            //Output: ""
            //Explanation: There is no common prefix among the input strings.

            string[] question1 = { "flower", "flow", "flight" };


            if (longestCommonPrefix(question1) == "fl")
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
        }

        private static string longestCommonPrefix(string[] strs)
        {
            string result = "";
            int longestText = strs[0].Length;
            int endData = strs.Length;
            int loop = 0;
            foreach (string data in strs)
            {
                longestText = (longestText > data.Length) ? data.Length : longestText;
            }


            while (longestText > loop)
            {
                char data = new char();
                for (int j = 0; j < endData; j++)
                {
                    if (j == 0)
                    {
                        data = strs[j][loop];
                    }
                    else if (strs[j][loop] == data)
                    {
                        if (j == endData - 1)
                        {
                            result += data.ToString();
                        }
                    }
                    else
                    {
                        return result;
                    }

                }
                loop++;
            }

            return result;
        }
    }
}
