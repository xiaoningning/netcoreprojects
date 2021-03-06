﻿using System;

namespace linkedListCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Solution();
            var head = new ListNode(1);
            head.next = new ListNode(2);
            var node3 = new ListNode(3);
            head.next.next = node3;
            var node4 = new ListNode(4);
            node3.next = node4;
            var node5 = new ListNode(5);
            node4.next = node5;
            node5.next = node3;
            Console.WriteLine("linked list has cycle: {0}", obj.HasCycle(head));
        }
    }
    /**
    * Definition for singly-linked list.
    */
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {
            val = x;
            next = null;
        }
    }
    
    public class Solution {
        public bool HasCycle(ListNode head) {
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null){
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }
            return false;        
        }
    }
}
