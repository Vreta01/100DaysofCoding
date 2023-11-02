using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    internal class LinkedListMaxPair
    {
        public int PairSum(ListNode head)
        {
            Stack<int> nodeStack = new Stack<int>();
            ListNode slow = head;
            ListNode fast = head.next;
            int maxSum = 0;

            nodeStack.Push(slow.val);

            while (fast.next != null)
            {
                slow = slow.next;
                nodeStack.Push(slow.val);
                fast = fast.next.next;
            }

            while (slow.next != null)
            {
                slow = slow.next;
                maxSum = Math.Max(maxSum, nodeStack.Pop() + slow.val);
            }
            return maxSum;
        }
    }
}
