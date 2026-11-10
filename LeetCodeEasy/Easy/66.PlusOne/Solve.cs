namespace LeetCode.Easy.PlusOne
{
    internal class Solve
    {
        public static void Run()
        {
            //int[] question = { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };
            int[] question = { 7, 2, 9 };

            int[] ans = plusOne(question);
            System.Console.WriteLine("TEST");
        }

        private static int[] plusOne(int[] digits)
        {
            int[] result = null;
            int tempData = 0;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i]++;
                if (digits[i] > 9)
                {
                    tempData = digits[i] / 10;
                    digits[i] = digits[i] % 10;
                    if (i == 0 && tempData != 0)
                    {
                        result = new int[digits.Length + 1];
                        result[0] = tempData;
                        for (int j = 1; j < result.Length; j++)
                            result[j] = digits[j - 1];
                        return result;
                    }
                }
                else
                    return digits;
            }

            return digits;
        }

        //private static int[] PlusOne(int[] digits)
        //{
        //    for (int i = digits.Length - 1; i >= 0; i--)
        //    {
        //        if (digits[i] < 9)
        //        {
        //            digits[i]++;
        //            return digits;
        //        }

        //        digits[i] = 0;
        //    }

        //    int[] result = new int[digits.Length + 1];
        //    result[0] = 1;

        //    return result;
        //}
    }
}
