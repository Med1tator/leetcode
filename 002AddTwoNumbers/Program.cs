using System;

namespace _002AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var l1 = new ListNode(2)
            //{
            //    next = new ListNode(4)
            //    {
            //        next = new ListNode(3)
            //    }
            //};
            //var l2 = new ListNode(5)
            //{
            //    next = new ListNode(6)
            //    {
            //        next = new ListNode(6)
            //    }
            //};

            //var l1 = new ListNode(0)
            //{
            //    next = new ListNode(1)
            //};
            //var l2 = new ListNode(0)
            //{
            //    next = new ListNode(1)
            //    {
            //        next = new ListNode(2)
            //    }
            //};

            var l1 = new ListNode(9)
            {
                next = new ListNode(9)
            };
            var l2 = new ListNode(1);


            var result = new Solution().AddTwoNumbers(l1, l2);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        // 给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。
        // 如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
        // 您可以假设除了数字 0 之外，这两个数都不会以 0 开头。

        // 示例：
        // 输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
        // 输出：7 -> 0 -> 8
        // 原因：342 + 465 = 807
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(0);
            var p = l1;
            var q = l2;
            var curr = result;
            var carry = 0;

            while (p != null || q != null)
            {
                var pVal = p?.val ?? 0;
                var qVal = q?.val ?? 0;
                var tempSum = pVal + qVal + carry;
                carry = tempSum / 10;
                curr.next = new ListNode(tempSum % 10);
                curr = curr.next;
                p = p?.next;
                q = q?.next;
            }

            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return result.next;
        }
    }
}
