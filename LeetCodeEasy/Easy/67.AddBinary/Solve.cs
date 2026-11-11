using System.Collections.Generic;

namespace LeetCode.Easy.AddBinary
{
    internal class Solve
    {
        public static void Run()
        {

            //Example 1:
            //Input: a = "11", b = "1"
            //Output: "100"

            //Example 2:
            //Input: a = "1010", b = "1011"
            //Output: "10101"

            string inputA = "11";
            string inputB = "1";

            string ans = addBinary(inputA, inputB);
            if (ans == "10101")
                System.Console.WriteLine("PASS");
            else
                System.Console.WriteLine("FAILED");



        }

        private static string addBinary(string a, string b)
        {

            int indexA = a.Length - 1;
            int indexB = b.Length - 1;

            int carry = 0;
            List<char> result = new List<char>();

            while (indexA >= 0 || indexB >= 0 || carry > 0)
            {
                int digitA = indexA >= 0 ? a[indexA--] - '0' : 0;
                int digitB = indexB >= 0 ? b[indexB--] - '0' : 0;

                int sum = digitA + digitB + carry;

                result.Add((char)('0' + sum % 2));

                carry = sum / 2;
            }

            result.Reverse();

            return new string(result.ToArray());
        }
    }
}
