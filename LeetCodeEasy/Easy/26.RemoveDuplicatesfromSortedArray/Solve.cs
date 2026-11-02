namespace LeetCode.Easy.RemoveDuplicatesfromSortedArray
{
    internal class Solve
    {
        public static void Run()
        {
            //Input: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
            //Output: 5, nums = [0, 1, 2, 3, 4, _, _, _, _, _]
            int[] question = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int res = removeDuplicates(question);
            if (res == 5)
            {
                System.Console.WriteLine("PASS");
            }
            else
            {
                System.Console.WriteLine($"FAILED with answer {res}");
            }
        }

        private static int removeDuplicates(int[] nums)
        {
            // ubah array nums menjadi sesuai dengan angka yang ada
            // output : jumlah unique angka
            int result = 1;
            int tempChecker = nums[0];
            int lastIndexUniqueNumber = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                var Check = nums[i];
                if (tempChecker != nums[i])
                {
                    nums[lastIndexUniqueNumber] = nums[i];
                    result++;
                    tempChecker = nums[i];
                    lastIndexUniqueNumber++;
                }
            }
            var check = nums;
            return result;
        }
    }
}
