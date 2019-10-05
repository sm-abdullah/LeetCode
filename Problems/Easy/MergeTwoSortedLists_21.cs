using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCoding.Problems.Easy
{
    public class MergeTwoSortedLists_21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            var f = l1.val <= l2.val ? l1 : l2;
            var l = l1.val > l2.val ? l1 : l2;
            var head = f;
            var current = f;
            f = f.next;
            while (f != null || l != null)
            {
                if (f != null && l != null)
                {
                    if (f.val < l.val)
                    {
                        current.next = f;
                        f = f.next;
                    }
                    else
                    {
                        current.next = l;
                        l = l.next;
                    }
                }
                else
                {
                    if (f != null)
                    {
                        current.next = f;
                        break;

                    }
                    if (l != null)
                    {
                        current.next = l;
                        break;
                    }
                }
                current = current.next;
            }
            return head;
        }

        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
