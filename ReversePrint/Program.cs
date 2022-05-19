using System;
using System.Collections.Generic;
namespace ReversePrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode head = new ListNode(1);
            head.next = new ListNode(3);
            head.next.next = new ListNode(2);
            ReversePrint(head);
        }
        static public int[] ReversePrint(ListNode head)
        {
            ListNode ListNdBuf = head;

            Stack<int> stk = new Stack<int>();
            for(int i = 0; ListNdBuf!=null; i++)
            {
                stk.Push(ListNdBuf.val);
                ListNdBuf = ListNdBuf.next;
            }
            int[] a = new int[stk.Count];
            for (int i = 0;stk.Count>0;i++)
            {
                a[i] = stk.Pop();
            }
            return a;
        }
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}