using System.Collections.Generic;

namespace LeetCodeEasy.Easy.MergeTwoSortedList
{
    internal class Solve
    {
        public static void Run()
        {
            // Input: list1 = [1,2,4], list2 = [1,3,4]
            // Output: [1,1,2,3,4,4]

            // Example 2:
            // Input: list1 = [], list2 = []
            // Output: []

            // Example 3:
            // Input: list1 = [], list2 = [0]
            // Output: [0]

            int[] tempRes = { 1, 1, 2, 3, 4, 4 };

            ListNode l1 = new ListNode(1,
                new ListNode(2,
                new ListNode(4)));

            ListNode l2 = new ListNode(1,
                            new ListNode(3,
                            new ListNode(4)));

            ListNode ans = mergeTwoLists(l1, l2);
            bool isTrue = true;
            int numCheck = 0;
            string ansResult = "";
            while (ans != null)
            {
                ListNode tempAnswer = ans;
                ansResult += $" {ans.val}";
                if (tempAnswer.val != tempRes[numCheck])
                {
                    isTrue = false;
                    break;
                }
                numCheck++;
                ans = ans.next;
            }

            System.Console.WriteLine(isTrue ? $"PASS!!! with data {ansResult}" : $"FAILED on Data - {numCheck + 1}!!!");
        }

        private static ListNode mergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = null;
            ListNode tail = null;


            if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }

            while (list1 != null || list2 != null)
            {
                int dataList1 = list1 != null ? list1.val : 0;
                int dataList2 = list2 != null ? list2.val : 0;
                int tempResult = 0;

                // result = list1 == null ? list2 : list1;
                if (list1 == null)
                {
                    tail.next = list2;
                    return result;
                }
                else if (list2 == null)
                {
                    tail.next = list1;
                    return result;
                }
                else if (dataList1 == dataList2)
                {
                    tempResult = dataList2;
                    list2 = list2.next;
                }
                else if (dataList1 > dataList2)
                {
                    list2 = list2.next;
                    tempResult = dataList2;
                }
                else
                {
                    list1 = list1.next;
                    tempResult = dataList1;
                }

                ListNode newNode = new ListNode(tempResult);

                if (result == null)
                {
                    result = newNode;
                    tail = result;
                }
                else
                {
                    tail.next = newNode;
                    tail = tail.next;
                }


            }

            return result;

        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}