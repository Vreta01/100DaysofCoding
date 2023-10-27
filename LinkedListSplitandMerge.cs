using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    
    internal class LinkedListSplitandMerge
    {
        public static ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
            { return head; }

            ListNode evenNodeStart = head.next;
            ListNode p1 = head;
            ListNode p2 = head.next;

            while (p2 != null && p2.next != null)
            {
                p1.next = p2.next;
                p2.next = p2.next.next;
                p1 = p1.next;
                p2 = p2.next;
            }
            p1.next = evenNodeStart;
            return head;
        }
    }
}
