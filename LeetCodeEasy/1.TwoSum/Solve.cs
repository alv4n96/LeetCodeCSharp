using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeEasy.TwoSum
{
    public class Solve
    {
        public static void Run()
        {
            //int[] nums = { 2, 7, 11, 15 };
            //int target = 9;
            //int[] result = new solve().twoSum(nums, target);
            //Console.WriteLine($"[{result[0]}, {result[1]}]");
            var res1 = twoSum(new int[] { 2, 7, 11, 15 }, 9);
            if (res1[0] == 0 && res1[1] == 1)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
        }

        private static int[] twoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Count(); i++)
            {
                int checker = target - nums[i];

                if (map.ContainsKey(checker))
                {
                    return new int[] { map[checker], i };
                }
                map[nums[i]] = i;
            }


            return new int[] { 0, 1 };
        }
        /*
         * 
    var map = new Dictionary<int, int>(nums.Length);

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];

        if (map.TryGetValue(complement, out int index))
            return new int[] { index, i };

        map[nums[i]] = i;
    }

    return Array.Empty<int>();
         */
    }
}
