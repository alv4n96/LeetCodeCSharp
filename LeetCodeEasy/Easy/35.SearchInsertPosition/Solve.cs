namespace LeetCode.Easy.SearchInsertPosition
{
    internal class Solve
    {
        public static void Run()
        {

            //Example 1:
            //Input: nums = [1, 3, 5, 6], target = 5
            //Output: 2

            //Example 2:
            //Input: nums = [1, 3, 5, 6], target = 2
            //Output: 1

            //Example 3:
            //Input: nums = [], target = 7
            //Output: 4

            int[] question = { 1, 3, 5, 6 };
            int target = 2;

            target = 8;

            int ans = searchInsert(question, target);

            if (ans == 2)
                System.Console.WriteLine("PASS");
            else
                System.Console.WriteLine("FAILED");
        }

        private static int searchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            if (nums[0] == target)
                return 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }


            return left;
        }
    }
}
