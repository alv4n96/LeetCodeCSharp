namespace LeetCode.Easy.RemoveElement
{
    internal class Solve
    {
        public static void Run()
        {
            //Example 1:
            //Input: nums = [3, 2, 2, 3], val = 3
            //Output: 2, nums = [2, 2, _, _]
            //Explanation: Your function should return k = 2, with the first two elements of nums being 2.
            //It does not matter what you leave beyond the returned k(hence they are underscores).

            //Example 2:
            //Input: nums = [0, 1, 2, 2, 3, 0, 4, 2], val = 2
            //Output: 5, nums = [0, 1, 4, 0, 3, _, _, _]
            //Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
            //Note that the five elements can be returned in any order.
            //It does not matter what you leave beyond the returned k(hence they are underscores).

            int[] question = { 0, 1, 2, 2, 3, 0, 4, 2 };
            //question = new int[] { 3, 2, 2, 3 };

            int ans = removeElement(question, 2);
            
            System.Console.WriteLine(question);
            System.Console.WriteLine(ans);

            if (ans == 5)
                System.Console.WriteLine("PASS");
            else
                System.Console.WriteLine("FAILED");


        }

        private static int removeElement(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;

            int tempDataValue = 0;
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                    continue;
                else
                {
                    nums[tempDataValue] = nums[i];
                    nums[i] = tempDataValue == i ? nums[i] : val;
                    tempDataValue++;
                    result++;
                }
            }

            return result;
        }
    }
}
