namespace LeetCode.Easy.LengthofLastWord
{
    internal class Solve
    {
        public static void Run()
        {

            //Example 1:
            //Input: s = "Hello World"
            //Output: 5
            //Explanation: The last word is "World" with length 5.

            //Example 2:
            //Input: s = "   fly me   to   the moon  "
            //Output: 4
            //Explanation: The last word is "moon" with length 4.

            //Example 3:
            //Input: s = "luffy is still joyboy"
            //Output: 6
            //Explanation: The last word is "joyboy" with length 6.

            string question = "   fly me   to   the moon  ";
            question = "a";

            int res = lengthOfLastWord(question);

            if (res == 4)
                System.Console.WriteLine("PASS");
            else
                System.Console.WriteLine("FAILED");


        }

        private static int lengthOfLastWord(string s)
        {
            int result = 0;
            bool isCharacterFound = false;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    isCharacterFound = true;
                    result++;
                }
                else if (isCharacterFound && s[i] == ' ')
                    return result;
                else
                    continue;

            }

            return result;
        }
    }
}
