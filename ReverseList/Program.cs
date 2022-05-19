using System;

namespace ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode head = new ListNode(1);
                     head.next = new ListNode(2);
                     head.next.next = new ListNode(3);
                     head.next.next.next = new ListNode(4);
                     head.next.next.next.next = new ListNode(5);
                     head.next.next.next.next.next = new ListNode(6);
            ReverseList(head);
        }
        static public ListNode ReverseList(ListNode head)
        {
            listin(head);
            return head;
        }
        //递归写法
        static public ListNode listin(ListNode head)
        {
            if(head == null||head.next == null)
            {
                return head;
            }
            var ans = listin(head.next);    //首先进入最后一个,ans指向最后一个结点，返回该结点；
            head.next.next = head;          //1.此时head为倒数第二个结点,让head.next.next=head即为指向反转
            head.next = null;               //2.反转指向后将之前的指向删除
            return ans;                     //ans为正序链表的尾结点，逆序链表的头结点
        }                                   //1.2.顺序不能反
    }

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}




