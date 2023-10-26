using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    public class ListNode(int val = 0, ListNode? next = null)
    {
      public int val = val;
      public ListNode? next = next;
    }

    internal class LinkedListDelete
    {
        public ListNode DeleteMiddle(ListNode head)
        {

            int count = 1;
            if (head.next == null)
            { return null; }
            if (head.next.next == null)
            {
                head.next = null;
                return head;
            }

            ListNode mid = head;
            ListNode start = head;

            while (head.next != null)
            {
                count++;
                if (count % 2 == 0)
                { mid = mid.next; }
                head = head.next;
            }
            mid.val = mid.next.val;
            mid.next = mid.next.next;
            return start;
        }
    }
}
