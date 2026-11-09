namespace LeetCode.Easy.FindtheIndexoftheFirstOccurrenceinaString
{
    internal class Solve
    {
        public static void Run()
        {

            //Example 1:
            //Input: haystack = "sadbutsad", needle = "sad"
            //Output: 0
            //Explanation: "sad" occurs at index 0 and 6.
            //The first occurrence is at index 0, so
            //we return 0.

            //Example 2:
            //Input: haystack = "leetcode", needle = "leeto"
            //Output: -1
            //Explanation: "leeto" did not occur in "leetcode", so we return -1.

            string input = "hello";
            string needle = "ll";

            input = "leetcode";
            needle = "leeto";

            input = "sadbutsad";
            needle = "sad";

            input = "mississippi";
            needle = "issipi";

            int ans = strStr(input, needle);

            if (ans == 0)
                System.Console.WriteLine("PASS");
            else
                System.Console.WriteLine("FAILED");

        }

        private static int strStr(string haystack, string needle)
        {
            int haystackLength = haystack.Length;
            if (needle.Length > haystackLength)
                return -1;
            int indexChecker = 0;
            int needleData = needle.Length - 1;

            for (int i = 0; i < haystackLength; i++)
            {
                if (haystack[i] == needle[0])
                {
                    while (indexChecker <= needleData)
                    {
                        if (indexChecker == needleData)
                            return i;
                        indexChecker++;
                        if (i + indexChecker > haystackLength - 1)
                            return -1;
                        if (haystack[i + indexChecker] != needle[indexChecker])
                        {
                            indexChecker = 0;
                            break;
                        }
                    }
                }
            }

            return -1;
        }
    }
}
