using System;

namespace LeetCode.Medium.AddTwoNumbers
{
    public class Solve
    {
        public static void Run()
        {
            // Input: l1 = [2, 4, 3], l2 = [5, 6, 4]
            // Output: [7, 0, 8]
            // Explanation: 342 + 465 = 708.

            ListNode l1 = new ListNode(2,
                new ListNode(4,
                new ListNode(3)));

            ListNode l2 = new ListNode(5,
                            new ListNode(6,
                            new ListNode(4)));

            //ListNode l1 = new ListNode(9,
            //    new ListNode(9,
            //    new ListNode(9,
            //    new ListNode(9,
            //    new ListNode(9,
            //    new ListNode(9,
            //    new ListNode(9)))))));

            //ListNode l2 = new ListNode(9,
            //    new ListNode(9,
            //    new ListNode(9,
            //    new ListNode(9))));

            int[] tempRes = { 7, 0, 8 };

            ListNode ans = addTwoNumbers(l1, l2);
            bool isTrue = true;
            int numCheck = 0;
            while (ans != null)
            {
                ListNode tempAnswer = ans;
                if (tempAnswer.val != tempRes[numCheck])
                {
                    isTrue = false;
                    break;
                }
                numCheck++;
                ans = ans.next;
            }

            Console.WriteLine(isTrue ? "PASS!!!" : $"FAILED on Data - {numCheck + 1}!!!");
        }

        private static ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode? result = null;
            ListNode? tail = null;
            int tempResult = 0;
            while (l1 != null || l2 != null || tempResult != 0)
            {
                int resultOperation = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + tempResult;
                int digit = resultOperation % 10;
                tempResult = resultOperation / 10;

                ListNode newNode = new ListNode(digit);

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


                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }
            return result;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null!)
            {
                this.val = val;
                this.next = next;
            }
        }

    }
}
